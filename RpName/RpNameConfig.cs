using Neuron.Core.Meta;
using PlayerRoles;
using Syml;
using System.Collections.Generic;
using System.ComponentModel;

namespace RpName
{
    [Automatic]
    [DocumentSection("Np Name")]
    public class RpNameConfig : IDocumentSection
    {
        [Description("The id of the role and the new name, ref to the doc of synapse")]
        public Dictionary<uint, string> RoleName { get; set; } = new Dictionary<uint, string>()
        {
            { (uint)RoleTypeId.ClassD,         "D-%randomNum%%randomNum%%randomNum%%randomNum%-%randomChar%%randomChar% (%playerName%)" },
            { (uint)RoleTypeId.Scientist,      "Dr %SecondName% %randomChar%. (%playerName%)"},
            { (uint)RoleTypeId.NtfCaptain,     "Captain %firstName% %SecondName% (%playerName%)"},
            { (uint)RoleTypeId.NtfSergeant,    "Sergeant %secondName% (%playerName%)" },
            { (uint)RoleTypeId.NtfSpecialist,  "Specialist %SecondName% (%playerName%)" },
            { (uint)RoleTypeId.NtfPrivate,     "Private %secondName% (%playerName%)" },
            { (uint)RoleTypeId.FacilityGuard,  "Security Officer %secondName% (%playerName%)" },
            { (uint)RoleTypeId.Scp049,         "SCP-049 (%playerName%)" },
            { (uint)RoleTypeId.Scp0492,        "SCP-049-2 (%playerName%)" },
            { (uint)RoleTypeId.Scp079,         "SCP-079 (%playerName%)" },
            { (uint)RoleTypeId.Scp096,         "SCP-096 (%playerName%)" },
            { (uint)RoleTypeId.Scp106,         "SCP-106 (%playerName%)" },
            { (uint)RoleTypeId.Scp173,         "SCP-173 (%playerName%)" },
            { (uint)RoleTypeId.Scp939,         "SCP-939 (%playerName%)" },
            { (uint)RoleTypeId.ChaosConscript, "Conscript %secondName% (%playerName%)" },
            { (uint)RoleTypeId.ChaosMarauder,  "Marauder %secondName% (%playerName%)" },
            { (uint)RoleTypeId.ChaosRepressor, "Repressor %secondName% (%playerName%)" },
            { (uint)RoleTypeId.ChaosRifleman,  "Rifleman %secondName% (%playerName%)" },
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
            "Valentin",
            "Oka",
            "Antonio",
            "Nils",
            "Christoph",
            "Lukas",
            "Flo",
            "Sönke",
            "Mathe ",
            "Adam", 
            "Mouloud",
            "Cristan"
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
