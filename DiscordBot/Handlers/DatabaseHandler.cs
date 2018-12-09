using Discord;
using Discord.Commands;
using DiscordBot.Services;
using DiscordBot.Utilities;
using System;
using System.Collections;
using System.Data.OleDb;

namespace DiscordBot.Handlers
{
    class DatabaseHandler
    {
        private readonly static string _className = "DatabaseHandler";
        private static ExecuteResult _result = new ExecuteResult();

        public static ExecuteResult CheckGuild(string guildID, string guildName)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

                command.CommandText = $"SELECT COUNT(*) FROM Guilds WHERE (GuildID = '{guildID}')";

                _connect.Open();
                
                if(Convert.ToInt32(command.ExecuteScalar()) == 0)
                {
                    AddGuild(guildID, guildName, ">");
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

        private static void AddGuild(string guildID, string guildName, string guildPrefix)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

                command.CommandText = $"INSERT INTO Guilds(GuildID, GuildPrefix) VALUES ('{guildID}','{guildPrefix}')";

                _connect.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, $"Guild {guildName} added to the database - assigned default prefix.");
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

        public static ExecuteResult RemoveGuild(string guildID, string guildName)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

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

        public static string CheckGuildPrefix(string guildID)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);
            string storedPrefix = "";

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

                command.CommandText = $"SELECT * FROM Guilds WHERE GuildID = '{guildID}'";

                _connect.Open();
                OleDbDataReader reader = command.ExecuteReader();

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
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

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

        public static ArrayList CheckRolePrecondition(string guildID)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);
            ArrayList roleCheck = new ArrayList();

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

                command.CommandText = $"SELECT * FROM GuildPreconditions WHERE (GuildID = '{guildID}')";

                _connect.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read()) { roleCheck.Add(reader); }
            }
            catch (Exception ex)
            {
                LoggingService.LogAsync(LogSeverity.Error, _className, ex.Message);
            }
            finally
            {
                _connect.Close();
            }

            return roleCheck;
        }

        public static ExecuteResult CheckExistingPreconditionRole(string guildID, string guildName, string precon, string roleName)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

                command.CommandText = $"SELECT COUNT(*) FROM GuildPreconditions WHERE (GuildID = '{guildID}') AND (GuildRole = '{roleName}')";

                _connect.Open();
                if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                {
                    AddPreconditionRole(guildID, guildName, precon, roleName);
                    _result = ExecuteResult.FromSuccess();
                }
                else
                {
                    LoggingService.LogAsync(LogSeverity.Info, _className, $"{roleName} already exists in {precon}.");
                    _result = ExecuteResult.FromError(CommandError.Unsuccessful, $"{roleName} already exists in {precon}.");
                }
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

        private static void AddPreconditionRole(string guildID, string guildName, string precon, string roleName)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

                command.CommandText = $"INSERT INTO GuildPreconditions(GuildID, Precondition, GuildRole) VALUES ('{guildID}', '{precon}', '{roleName}')";

                _connect.Open();
                command.ExecuteNonQuery();

                LoggingService.LogAsync(LogSeverity.Info, _className, $"Role {roleName} was added to {precon} for {guildName}");
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

        public static ExecuteResult RemoveExistingPreconditionRole(string guildID, string guildName, string precon, string roleName)
        {
            OleDbConnection _connect = new OleDbConnection(Constants._connectionString);

            try
            {
                OleDbCommand command = new OleDbCommand { Connection = _connect };

                command.CommandText = $"DELETE FROM GuildPreconditions WHERE (GuildID = '{guildID}') AND (GuildRole = '{roleName}')";

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
    }
}
