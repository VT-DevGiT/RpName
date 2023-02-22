using Neuron.Core.Plugins;
using Synapse3.SynapseModule;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using YamlDotNet.Core.Tokens;

namespace RpName
{
    [Plugin(
    Name = "RpName",
    Description = "A plugin that assigns rp names to the player based on their class",
    Version = "2.0.0",
    Author = "VT"
    )]
    public class RpNamePlugin : ReloadablePlugin<RpNameConfig, RpNameTranslations>
    {
        const string TAG_FristName = "%firstName%";
        const string TAG_SecondName = "%secondName%";
        const string TAG_RandomNum = "%randomNum%";
        const string TAG_RandomChar = "%randomChar%";
        const string TAG_PlayerName = "%playerName%";

        private Random rnd = new Random();

        public string RandomNum => rnd.Next(1, 9).ToString();
        public string RandomChar => rnd.Next('a', 'z').ToString();

        public string ReplaceFirst(string text, int index, int size, string replace)
        {
            if (index < 0)
            {
                return text;
            }
            return text.Substring(0, index) + replace + text.Substring(index + size);
        }

        public string GetName(uint id, string playerName)
        {
            if (!Config.RoleName.TryGetValue(id, out string rule))
                return null;

            if (Config.FirstName != null && Config.FirstName.Any())
            {
                var index = UnityEngine.Random.Range(0, Config.FirstName.Count);
                var firstName = Config.FirstName[index];
                rule = Regex.Replace(rule, TAG_FristName, firstName, RegexOptions.IgnoreCase);
            }
            if (Config.SecondName != null && Config.SecondName.Any())
            {
                var index = UnityEngine.Random.Range(0, Config.SecondName.Count);
                var secondName = Config.SecondName[index];
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
    }
}
