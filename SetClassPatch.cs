using HarmonyLib;
using Synapse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CharacterClassManager;

namespace RpName
{
    [HarmonyPatch(typeof(CharacterClassManager), nameof(CharacterClassManager.SetClassIDAdv))]
    class SetClassPatch
    {

        [HarmonyPostfix]
        private static void SetClassIDAdvPatch(CharacterClassManager __instance, RoleType id, bool lite, SpawnReason spawnReason, bool isHook = false)
        {
            try
            {
                var player = __instance.GetPlayer();
                if (player?.RoleID == 56) // for not be sus
                {
                    var name = PluginClass.GetName((int)id);
                    if (string.IsNullOrEmpty(name))
                        player.name = player.NickName;
                    else
                        player.name = name;
                }
                    
            }
            catch (Exception e)
            {
                Server.Get.Logger.Error($"RpName : SetClassAdvPatch failed!!\n{e}\nStackTrace:\n{e.StackTrace}");
            }
        }

    }
}
