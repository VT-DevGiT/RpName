using System.Collections.Generic;
using System.ComponentModel;

namespace RpName
{
    public class PluginConfig
    {
        [Description("The id of the role and the new name, ref to the doc of synapse")]
        public Dictionary<int, string> RoleName { get; set; } = new Dictionary<int, string>()
        {
            { (int)RoleType.ClassD,         "D-%randomNum%%randomNum%%randomNum%%randomNum%-%randomChar%%randomChar% (%playerName%)" },
            { (int)RoleType.Scientist,      "Dr %SecondName% %randomChar%. (%playerName%)"},
            { (int)RoleType.NtfCaptain,     "Captain %firstName% %SecondName% (%playerName%)"},
            { (int)RoleType.NtfSergeant,    "Sergeant %secondName% (%playerName%)" },
            { (int)RoleType.NtfSpecialist,  "Specialist %SecondName% (%playerName%)" },
            { (int)RoleType.NtfPrivate,     "Private %secondName% (%playerName%)" },
            { (int)RoleType.FacilityGuard,  "Security Officer %secondName% (%playerName%)" },
            { (int)RoleType.Scp049,         "SCP-049 (%playerName%)" },
            { (int)RoleType.Scp0492,        "SCP-049-2 (%playerName%)" },
            { (int)RoleType.Scp079,         "SCP-079 (%playerName%)" },
            { (int)RoleType.Scp096,         "SCP-096 (%playerName%)" },
            { (int)RoleType.Scp106,         "SCP-106 (%playerName%)" },
            { (int)RoleType.Scp173,         "SCP-173 (%playerName%)" },
            { (int)RoleType.Scp93953,       "SCP-939-53 (%playerName%)" },
            { (int)RoleType.Scp93989,       "SCP-939-89 (%playerName%)" },
            { (int)RoleType.ChaosConscript, "Conscript %secondName% (%playerName%)" },
            { (int)RoleType.ChaosMarauder,  "Marauder %secondName% (%playerName%)" },
            { (int)RoleType.ChaosRepressor, "Repressor %secondName% (%playerName%)" },
            { (int)RoleType.ChaosRifleman,  "Rifleman %secondName% (%playerName%)" },
        };

        public List<string> FirstName { get; set; } = new List<string>()
        {
            "James",
            "John",
            "Robert",
            "Michael",
            "William",
            "David",
            "Richard",
            "Joseph",
            "Thomas",
            "Charles",
            "Christopher",
            "Daniel",
            "Matthew",
            "Anthony",
            "Donald",
            "Mark",
            "Paul",
            "Steven",
            "Andrew",
            "Kenneth",
            "Joshua",
            "Kevin",
            "Brian",
            "George",
            "Patric",
            "Edward",
            "Ronald",
            "Timothy",
            "Jason",
            "Jeffrey",
            "Ryan",
            "Jacob",
            "Gary",
            "Nicholas",
            "Eric",
            "Jonathan",
            "Stephen",
            "Larry",
            "Justin",
            "Scott",
            "Brandon",
            "Valentin",//Som Synapse Dev :)
            "Oka",
            "Antonio",
            "Nils",
            "Christoph",
            "Lukas",
            "Flo",
            "Sönke",
            "Mathe ",
            "Adam", // random name lol
            "Mouloud", // I dont ave the name of bonjemus :'(
        };

        public List<string> SecondName { get; set; } = new List<string>()
        {
            "Smith",
            "Johnson",
            "Williams",
            "Brown",
            "Jones",
            "Miller",
            "Davis",
            "Wilson",
            "Anderson",
            "Taylor",
            "Garcia",
            "Thomas",
            "Moore",
            "Martin",
            "Rodriguez",
            "Lee",
            "White",
            "Thompson",
            "Jackson",
            "Martinez",
            "Hyde", 
            "Hood", 
            "Hull", 
            "Hogan", 
            "Hitchens",
            "Higgins", 
            "Hodder", 
            "Huxx",
            "Hester",
            "Fleetwood", 
            "Fugger", 
            "Frost", 
            "Curry", 
            "Ambrose", 
            "Baudin",
            "Fishman"
        };

    }
}
