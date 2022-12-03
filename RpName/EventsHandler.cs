using Synapse.Api.Events.SynapseEventArguments;
using System.Linq;
using System.Text.RegularExpressions;

namespace RpName
{
    public class EventsHandler
    {
        public EventsHandler()
        {
            Synapse.Api.Events.EventHandler.Get.Player.PlayerSetClassEvent += OnSetClass;
        }

        private void OnSetClass(PlayerSetClassEventArgs ev)
        {
            if (PluginClass.Config.RoleName != null && PluginClass.Config.RoleName.Any())
            {
                var id = ev.Player.RoleID;

                var name = PluginClass.GetName(id, ev.Player.NickName);
                if (string.IsNullOrEmpty(name))
                    ev.Player.name = ev.Player.NickName;
                else
                    ev.Player.name = name;
            }
        }
    }
}