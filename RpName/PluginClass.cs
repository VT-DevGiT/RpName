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
        const string FristNameTag = "%firstName%";
        const string SecondNameTag = "%secondName%";
        const string RandomNumTag = "%randomNum%";
        const string RandomCharTag = "%randomChar%";
        const string PlayerNameTag = "%playerName%";

        [Config(section = "RpName")]
        public static PluginConfig Config { get; set; }

        private static Random rnd = new Random();

        public static string RandomFigure => rnd.Next(1, 9).ToString();
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
                var firstName = PluginClass.Config.FirstName[UnityEngine.Random.Range(0, PluginClass.Config.FirstName.Count)];
                rule = Regex.Replace(rule, FristNameTag, firstName, RegexOptions.IgnoreCase);
            }
            if (PluginClass.Config.SecondName != null && PluginClass.Config.SecondName.Any())
            {
                var secondName = PluginClass.Config.SecondName[UnityEngine.Random.Range(0, PluginClass.Config.SecondName.Count)];
                rule = Regex.Replace(rule, SecondNameTag, secondName, RegexOptions.IgnoreCase);
            }

            rule = Regex.Replace(rule, PlayerNameTag, playerName, RegexOptions.IgnoreCase);
            
            {
                int pos = rule.IndexOf(RandomFigure, System.StringComparison.OrdinalIgnoreCase);
                while (pos >= 0)
                {
                    rule = ReplaceFirst(rule, pos, RandomFigure.Length, RandomFigure);
                    pos = rule.IndexOf(RandomFigure, pos, System.StringComparison.OrdinalIgnoreCase);
                }
            }
            
            {
                int pos = rule.IndexOf(RandomCharTag, System.StringComparison.OrdinalIgnoreCase);
                while (pos >= 0)
                {
                    byte number = (byte)UnityEngine.Random.Range(1, 9);
                    rule = ReplaceFirst(rule, pos, RandomCharTag.Length, RandomChar);
                    pos = rule.IndexOf(RandomCharTag, pos, System.StringComparison.OrdinalIgnoreCase);
                }
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
