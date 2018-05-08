using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiscordBot.Init
{
    public class ImageInitialization
    {
        private static string reactionFolder = @"\Content\Reactions\";
        private static string roleplayFolder = @"\Content\RolePlay\";

        public static void Init()
        {
            //Reaction Image Files
            Kiss = ReadFileToList("kiss.txt", reactionFolder);
            Tickle = ReadFileToList("tickle.txt", reactionFolder);
            Pinch = ReadFileToList("pinch.txt", reactionFolder);
            Wave = ReadFileToList("wave.txt", reactionFolder);
            Rude = ReadFileToList("rude.txt", reactionFolder);
            Cake = ReadFileToList("cake.txt", reactionFolder);
            Cuddle = ReadFileToList("cuddle.txt", reactionFolder);
            Glare = ReadFileToList("glare.txt", reactionFolder);
            Highfive = ReadFileToList("highfive.txt", reactionFolder);
            Hug = ReadFileToList("hug.txt", reactionFolder);
            Poke = ReadFileToList("poke.txt", reactionFolder);
            Punch = ReadFileToList("punch.txt", reactionFolder);
            Pat = ReadFileToList("pat.txt", reactionFolder);
            Slap = ReadFileToList("slap.txt", reactionFolder);
            Bite = ReadFileToList("bite.txt", reactionFolder);
            Lick = ReadFileToList("lick.txt", reactionFolder);

            //RolePlay Image Files
            //RubLegs = ReadFileToList("rub.txt", roleplayFolder);
        }

        public static void Clear()
        {
            Kiss.Clear();
            Tickle.Clear();
            Pinch.Clear();
            Wave.Clear();
            Rude.Clear();
            Cake.Clear();
            Cuddle.Clear();
            Glare.Clear();
            Highfive.Clear();
            Hug.Clear();
            Poke.Clear();
            Punch.Clear();
            Pat.Clear();
            Slap.Clear();
            Bite.Clear();
            Lick.Clear();
        }

        public static List<string> Kiss, Tickle, Pinch, Wave, Rude, Cake, Cuddle, Glare, Highfive, Hug, Poke, Punch, Pat, Slap, Bite, Lick;
        public static List<string> RubLegs;

        private static List<string> ReadFileToList(string textFile, string folder)
        {
            List<string> allLinesText = File.ReadAllLines(Environment.CurrentDirectory + folder + textFile).ToList();
            return allLinesText;
        }
    }
}
