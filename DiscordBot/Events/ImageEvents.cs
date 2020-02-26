using Discord;
using DiscordBot.Objects;
using DiscordBot.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiscordBot.Events
{
    class ImageEvents
    {
        private static readonly Random ran = new Random();

        public static string KissReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Kiss[ran.Next(0, rObject.Action.Kiss.Count)];
        }

        public static string TickleReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Tickle[ran.Next(0, rObject.Action.Tickle.Count)];
        }

        internal static string PinchReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Pinch[ran.Next(0, rObject.Action.Pinch.Count)];
        }

        internal static string WaveReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Wave[ran.Next(0, rObject.Action.Wave.Count)];
        }

        internal static string FlipReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Flip[ran.Next(0, rObject.Action.Flip.Count)];
        }

        internal static string CakeReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Cake[ran.Next(0, rObject.Action.Cake.Count)];
        }

        internal static string CuddleReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Cuddle[ran.Next(0, rObject.Action.Cuddle.Count)];
        }

        internal static string GlareReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Glare[ran.Next(0, rObject.Action.Glare.Count)];
        }

        internal static string HighfiveReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Highfive[ran.Next(0, rObject.Action.Highfive.Count)];
        }

        internal static string HugReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Hug[ran.Next(0, rObject.Action.Hug.Count)];
        }

        internal static string PokeReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Poke[ran.Next(0, rObject.Action.Poke.Count)];
        }

        internal static string PunchReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Punch[ran.Next(0, rObject.Action.Punch.Count)];
        }

        internal static string PatReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Pat[ran.Next(0, rObject.Action.Pat.Count)];
        }

        internal static string PetReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Pet[ran.Next(0, rObject.Action.Pet.Count)];
        }

        internal static string SlapReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Slap[ran.Next(0, rObject.Action.Slap.Count)];
        }

        internal static string BiteReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Bite[ran.Next(0, rObject.Action.Bite.Count)];
        }

        internal static string GrooveReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Groove[ran.Next(0, rObject.Action.Groove.Count)];
        }

        internal static string ConfusedReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Confused[ran.Next(0, rObject.Action.Confused.Count)];
        }

        internal static string PoutReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Pout[ran.Next(0, rObject.Action.Pout.Count)];
        }

        internal static string StareReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Stare[ran.Next(0, rObject.Action.Stare.Count)];
        }

        internal static string CriesReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Cries[ran.Next(0, rObject.Action.Cries.Count)];
        }

        internal static string TackleReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Tackle[ran.Next(0, rObject.Action.Tackle.Count)];
        }

        internal static string SuplexeReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Suplexe[ran.Next(0, rObject.Action.Suplexe.Count)];
        }

        internal static string LoveReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Sends_love[ran.Next(0, rObject.Action.Sends_love.Count)];
        }

        internal static string HeartReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Heart[ran.Next(0, rObject.Action.Heart.Count)];
        }

        internal static string DroolReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Drool[ran.Next(0, rObject.Action.Drool.Count)];
        }

        internal static string CookieReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Cookie[ran.Next(0, rObject.Action.Cookie.Count)];
        }

        internal static string MeowReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Meow[ran.Next(0, rObject.Action.Meow.Count)];
        }

        internal static string SmugReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Smug[ran.Next(0, rObject.Action.Smug.Count)];
        }

        internal static string LewdReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Lewd[ran.Next(0, rObject.Action.Lewd.Count)];
        }

        internal static string CheerReaction()
        {
            ReactionObject rObject = JsonConvert.DeserializeObject<ReactionObject>(File.ReadAllText(Constants._rcPath));
            return rObject.Action.Cheer[ran.Next(0, rObject.Action.Cheer.Count)];
        }

        //TODO Remove smaller images and replace with larger ones
        
    }

    
}
