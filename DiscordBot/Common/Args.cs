using Discord;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiscordBot.Common
{
    public class Args
    {
        internal List<string> args;

        public int Count => args.Count;

        public Args(string a)
        {
            args = new List<string>();
            args.AddRange(a.Split(' '));
            args.RemoveAll(x => string.IsNullOrEmpty(x));
        }

        public bool Contains(string arg) { return args.Contains(arg); }

        public ArgObject First() => Get(0);
        public ArgObject FirstOrDefault() => (Count > 0) ? First() : null;
        public ArgObject Last() => Get(Count - 1);
        public ArgObject LastOrDefault() => (Count > 0) ? First() : null;

        public ArgObject Get(int index)
        {
            index = Math.Min(Math.Max(index, 0), args.Count);
            if (index >= args.Count) return null;
            return new ArgObject(args[index], index, this);
        }

        public ArgObject Join() => new ArgObject(string.Join(" ", args), 0, this);

        public void Remove(string value) { args.Remove(value); }

        public IEnumerable<ArgObject> Where(Func<string, bool> predicate)
        {
            List<ArgObject> allObjects = new List<ArgObject>();

            for(int i = 0; i < Count; i++)
            {
                if(predicate(Get(i).Argument)) { allObjects.Add(Get(i)); }
            }

            return allObjects;
        }

        public override string ToString() { return Join().Argument; }
    }

    public class ArgObject
    {
        public string Argument { get; private set; }

        readonly Args args;
        readonly int index;

        public bool IsLast => (args.Count - 1 == index);
        public bool IsMention => Regex.IsMatch(Argument, "<@(!?)\\d+>");

        public ArgObject(string arg, int index, Args a)
        {
            Argument = arg;
            this.index = index;
            args = a;
        }

        public int AsInt(int defaultValue = 0)
        {
            if(int.TryParse(Argument, out int s)) { return s; }
            return defaultValue;
        }

        public bool? AsBoolean()
        {
            if(bool.TryParse(Argument, out bool s)) { return s; }
            return null;
        }

        public ArgObject TakeUntilEnd(int offset = 0)
        {
            ArgObject o = this;
            for(int i = index + 1; i < args.Count - offset; i++) { o.Argument += " " + args.Get(i).Argument; }
            return o;
        }

        public async Task<IUser> GetUserAsync(IGuild guild)
        {
            if(IsMention)
            {
                return await guild.GetUserAsync(ulong.Parse(Argument.TrimStart('<').TrimStart('@').TrimStart('!').TrimEnd('>')));
            }
            else if(ulong.TryParse(Argument, out ulong id))
            {
                return await guild.GetUserAsync(id);
            }

            return await guild.GetUserAsync(ulong.Parse(Argument));
        }

        public ArgObject Next()
        {
            if (IsLast) return null;
            return args.Get(index + 1);
        }
    }
}
