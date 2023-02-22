using MEC;
using Neuron.Core.Events;
using Neuron.Core.Meta;
using Synapse3.SynapseModule;
using Synapse3.SynapseModule.Events;
using System.Linq;
using System.Xml.Linq;

namespace RpName
{
    [Automatic]
    public class EventsHandler : Listener
    {
        private readonly RpNamePlugin _plugin;

        public EventsHandler(RpNamePlugin plugin, PlayerEvents playerEvents)
        {
            SynapseLogger<EventsHandler>.Info("EventsHandler");
            _plugin = plugin;
            playerEvents.SetClass.Subscribe(OnSetClass);
        }

        private void OnSetClass(SetClassEvent ev)
        {
            Timing.CallDelayed(0.1f, () => 
            {
                if (_plugin.Config.RoleName != null && _plugin.Config.RoleName.Any())
                {
                    var id = ev.Player.RoleID;

                    if (id == 56)
                        id = (uint)ev.Player.RoleType;
                    var name = _plugin.GetName(id, ev.Player.NickName);
                    if (string.IsNullOrEmpty(name))
                        ev.Player.DisplayName = ev.Player.NickName;
                    else
                        ev.Player.DisplayName = name;
                }
            });
            
        }
    }
}