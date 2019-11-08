using Discord;
using Discord.Commands;
using DiscordBot.Services;
using DiscordBot.Utilities;
using System;
using System.Data.SQLite;
using System.Reflection;

namespace DiscordBot.Managers
{
    static class DatabaseManager
    {
        private readonly static string _className = MethodBase.GetCurrentMethod().DeclaringType.Name;
        private static ExecuteResult _result = new ExecuteResult();
        private static ulong guildRole;
        private static ulong guildChannel;

        private static SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

        //TODO Sanitize SQL inputs

        // Create Database
        public static void CreateGuildTable()
        {
            SQLiteConnection conn = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                string createGuildTable = "CREATE TABLE Guilds (GuildID BIGINT(40), GuildPrefix VARCHAR(3), CurrencyModule INTEGER(1), ReactionModule INTEGER(1))";

                SQLiteCommand command = new SQLiteCommand(createGuildTable, conn);

                conn.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, "Database table GUILDS has been created.");
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void CreateUserTable()
        {
            SQLiteConnection conn = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                string createTable = "CREATE TABLE GuildUsers (GuildID BIGINT(40), UserID BIGINT(40))";

                SQLiteCommand command = new SQLiteCommand(createTable, conn);

                conn.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, "Database table GUILDUSERS has been created.");
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void CreatePreconTable()
        {
            SQLiteConnection conn = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                string createTable = "CREATE TABLE GuildPrecon (GuildID BIGINT(40), PreconName VARCHAR(20), PreconRole BIGINT(40), PreconChannel BIGINT(40))";

                SQLiteCommand command = new SQLiteCommand(createTable, conn);

                conn.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, "Database table GUILDPRECON has been created.");
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Guild
        private static void AddGuild(string guildID, string guildName)
        {
            string guildPrefix = ">";

            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"INSERT INTO Guilds(GuildID, GuildPrefix, CurrencyModule) VALUES ('{guildID}','{guildPrefix}', '0')";

                _connect.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, $"Guild {guildName} added to the database - assigned default prefix and settings.");
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }
        }

        public static string CheckGuildPrefix(string guildID)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);
            string storedPrefix = "";

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"SELECT * FROM Guilds WHERE GuildID = '{guildID}'";

                _connect.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read()) { storedPrefix = reader["GuildPrefix"].ToString(); }
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return storedPrefix;
        }

        public static void ChangeGuildPrefix(string guildID, string guildName, string newPrefix)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"UPDATE Guilds SET [GuildPrefix] = '{newPrefix}' WHERE [GuildID] = '{guildID}'";

                _connect.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, $"Prefix has been changed for {guildName} to {newPrefix}.");
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }
        }

        public static ExecuteResult CheckGuild(string guildID, string guildName)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"SELECT COUNT(*) FROM Guilds WHERE (GuildID = '{guildID}')";

                _connect.Open();

                if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                {
                    AddGuild(guildID, guildName);
                    _result = ExecuteResult.FromSuccess();
                }
                else
                {
                    LoggingService.LogAsync(LogSeverity.Info, _className, $"Guild {guildName} already exists in database.");
                    _result = ExecuteResult.FromError(CommandError.Unsuccessful, $"Guild {guildName} already exists in database.");
                }
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
                _result = ExecuteResult.FromError(CommandError.Exception, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return _result;
        }

        public static ExecuteResult RemoveGuild(string guildID, string guildName)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"DELETE FROM Guilds WHERE GuildID = '{guildID}'";

                _connect.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, $"Guild {guildName} removed from the database.");
                _result = ExecuteResult.FromSuccess();
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
                _result = ExecuteResult.FromError(CommandError.Exception, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return _result;
        }

        //Check Users


        // Precondition
        public static ExecuteResult AddPreconditionRole(SocketCommandContext context, string preconName, ulong roleID)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"INSERT INTO GuildPrecon(GuildID, PreconName, PreconRole, PreconChannel) VALUES ('{context.Guild.Id}', '{preconName}', '{roleID}', '0')";

                _connect.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, $"Role {roleID} was added to {preconName} for {context.Guild.Name}");
                _result = ExecuteResult.FromSuccess();
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
                _result = ExecuteResult.FromError(CommandError.Unsuccessful, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return _result;
        }

        public static ExecuteResult AssignPreconditionToChannel(SocketCommandContext context, string preconName, ulong roleID, ulong channelID)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"INSERT INTO GuildPrecon(GuildID, PreconName, PreconRole, PreconChannel) VALUES ('{context.Guild.Id}', '{preconName}', '{roleID}', '{channelID}')";

                _connect.Open();
                command.ExecuteNonQuery();
                LoggingService.LogAsync(LogSeverity.Info, _className, $"Role {preconName} been assigned to {roleID} to only be used in {channelID} for {context.Guild.Name.ToString()}");
                _result = ExecuteResult.FromSuccess();
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
                _result = ExecuteResult.FromError(CommandError.Unsuccessful, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return _result;
        }

        public static ExecuteResult RemovePreconditionRole(SocketCommandContext context, string preconName, ulong roleID)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"DELETE FROM GuildPrecon WHERE (GuildID = '{context.Guild.Id}') AND (PreconName = '{preconName}') AND (PreconRole = '{roleID}')";

                _connect.Open();
                command.ExecuteNonQuery();
                _result = ExecuteResult.FromSuccess();
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
                _result = ExecuteResult.FromError(CommandError.Unsuccessful, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return _result;
        }

        public static ulong CheckPreconditionRole(ICommandContext context, string preconName)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"SELECT PreconRole FROM GuildPrecon WHERE GuildID = '{context.Guild.Id.ToString()}' AND PreconName = '{preconName}'";

                _connect.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read()) { guildRole = Convert.ToUInt64(reader["PreconRole"]); }
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return guildRole;
        }

        public static ulong CheckPreconditionChannel(ICommandContext context, string preconName)
        {
            SQLiteConnection _connect = new SQLiteConnection(Constants.ConnectionString);

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"SELECT PreconChannel FROM GuildPrecon WHERE GuildID = '{context.Guild.Id.ToString()}' AND PreconName = '{preconName}'";

                _connect.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read()) { guildChannel = Convert.ToUInt64(reader["PreconChannel"]); }
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return guildChannel;
        }

        // Modules
        public static bool CheckModuleStatus(string moduleName, string guildID)
        {
            int moduleStatus = 0;
            bool isActive = false;

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"SELECT {moduleName} FROM Guilds WHERE GuildID = {guildID}";

                _connect.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read()) { moduleStatus = int.Parse(reader[$"{moduleName}"].ToString()); }

                if (moduleStatus == 1)
                {
                    isActive = true;
                }
                else if (moduleStatus == 0)
                {
                    isActive = false;
                }
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return isActive;
        }

        public static ExecuteResult ChangeModuleStatus(string moduleName, string guildID, bool moduleStatus)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                if (CheckModuleStatus(moduleName, guildID) == false)
                {
                    command.CommandText = $"UPDATE Guilds SET [{moduleName}] = '1' WHERE [GuildID] = '{guildID}'";
                    _result = ExecuteResult.FromSuccess();
                }
                else if (CheckModuleStatus(moduleName, guildID) == true)
                {
                    command.CommandText = $"UPDATE Guilds SET [{moduleName}] = '0' WHERE [GuildID] = {guildID}";
                    _result = ExecuteResult.FromSuccess();
                }

                _connect.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, $"{moduleName} has been changed for {guildID}.");
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
                _result = ExecuteResult.FromError(CommandError.Unsuccessful, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return _result;
        }

        // Commands
        public static ExecuteResult AddRoleToAutoAssign(SocketCommandContext context, ulong roleID)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
                _result = ExecuteResult.FromError(CommandError.Unsuccessful, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return _result;
        }

        public static bool CheckCommandStatus(string commandName, string guildID)
        {
            int moduleStatus = 0;
            bool isActive = false;

            try
            {
                SQLiteCommand command = new SQLiteCommand { Connection = _connect };

                command.CommandText = $"SELECT {commandName} FROM Guilds WHERE GuildID = {guildID}";

                _connect.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read()) { moduleStatus = int.Parse(reader[$"{commandName}"].ToString()); }

                if (moduleStatus == 1)
                {
                    isActive = true;
                }
                else if (moduleStatus == 0)
                {
                    isActive = false;
                }
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return isActive;
        }
    }
}
