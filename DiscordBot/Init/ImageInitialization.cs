using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiscordBot.Init
{
    public class ImageInitialization
    {
        public static void Init()
        {
            //SFW Image Files
            Kiss = ReadFileToList("kiss.txt");
            Tickle = ReadFileToList("tickle.txt");
            Pinch = ReadFileToList("pinch.txt");
            Wave = ReadFileToList("wave.txt");
            Rude = ReadFileToList("rude.txt");
            Cake = ReadFileToList("cake.txt");
            Cuddle = ReadFileToList("cuddle.txt");
            Glare = ReadFileToList("glare.txt");
            Highfive = ReadFileToList("highfive.txt");
            Hug = ReadFileToList("hug.txt");
            Poke = ReadFileToList("poke.txt");
            Punch = ReadFileToList("punch.txt");
            Pat = ReadFileToList("pat.txt");
            Slap = ReadFileToList("slap.txt");
            Bite = ReadFileToList("bite.txt");
            Lick = ReadFileToList("lick.txt");

            //NSFW Image Files
            
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

        public static List<string> Kiss;
        public static List<string> Tickle;
        public static List<string> Pinch;
        public static List<string> Wave;
        public static List<string> Rude;
        public static List<string> Cake;
        public static List<string> Cuddle;
        public static List<string> Glare;
        public static List<string> Highfive;
        public static List<string> Hug;
        public static List<string> Poke;
        public static List<string> Punch;
        public static List<string> Pat;
        public static List<string> Slap;
        public static List<string> Bite;
        public static List<string> Lick;

        private static List<string> ReadFileToList(string textFile)
        {
            List<string> allLinesText = File.ReadAllLines(Environment.CurrentDirectory + @"\content\Reactions\" + textFile).ToList();
            return allLinesText;
        }
    }
}
