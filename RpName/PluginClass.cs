using Synapse.Api.Plugin;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RpName
{
    [PluginInformation(
        Name = "RpName",
        Author = "VT",
        Description = "a plugin that assigns rp names to the player based on their class",
        LoadPriority = -1,
        SynapseMajor = SynapseVersion.Major,
        SynapseMinor = SynapseVersion.Minor,
        SynapsePatch = SynapseVersion.Patch,
        Version = "v1.0.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        const string TAG_FristName = "%firstName%";
        const string TAG_SecondName = "%secondName%";
        const string TAG_RandomNum = "%randomNum%";
        const string TAG_RandomChar = "%randomChar%";
        const string TAG_PlayerName = "%playerName%";

        [Config(section = "RpName")]
        public static PluginConfig Config { get; set; }

        private static Random rnd = new Random();

        public static string RandomNum => rnd.Next(1, 9).ToString();
        public static string RandomChar => rnd.Next('a', 'z').ToString();

        public static string ReplaceFirst(string text, int index, int size, string replace)
        {
            if (index < 0)
            {
                return text;
            }
            return text.Substring(0, index) + replace + text.Substring(index + size);
        }

        public static string GetName(int id, string playerName)
        {
            if (!PluginClass.Config.RoleName.TryGetValue(id, out string rule))
                return null;

            if (PluginClass.Config.FirstName != null && PluginClass.Config.FirstName.Any())
            {
                var index = UnityEngine.Random.Range(0, PluginClass.Config.FirstName.Count);
                var firstName = PluginClass.Config.FirstName[index];
                rule = Regex.Replace(rule, TAG_FristName, firstName, RegexOptions.IgnoreCase);
            }
            if (PluginClass.Config.SecondName != null && PluginClass.Config.SecondName.Any())
            {
                var index = UnityEngine.Random.Range(0, PluginClass.Config.SecondName.Count);
                var secondName = PluginClass.Config.SecondName[index];
                rule = Regex.Replace(rule, TAG_SecondName, secondName, RegexOptions.IgnoreCase);
            }

            rule = Regex.Replace(rule, TAG_PlayerName, playerName, RegexOptions.IgnoreCase);
            int pos;
            
            pos = rule.IndexOf(TAG_RandomNum, StringComparison.OrdinalIgnoreCase);
            while (pos >= 0)
            {
                rule = ReplaceFirst(rule, pos, TAG_RandomNum.Length, RandomNum);
                pos = rule.IndexOf(TAG_RandomNum, pos, StringComparison.OrdinalIgnoreCase);
            }
            
            pos = rule.IndexOf(TAG_RandomChar, StringComparison.OrdinalIgnoreCase);
            while (pos >= 0)
            {
                byte number = (byte)UnityEngine.Random.Range(1, 9);
                rule = ReplaceFirst(rule, pos, TAG_RandomChar.Length, RandomChar);
                pos = rule.IndexOf(TAG_RandomChar, pos, StringComparison.OrdinalIgnoreCase);
            }

            return rule;
        }

        public override void Load()
        {
            new EventsHandler();
            base.Load();
        }
    }
}
