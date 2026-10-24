using EFT.GameTriggers;
using HarmonyLib;
using SPT.Reflection.Patching;
using System.Reflection;

namespace Tosox.PropaneRemover.Patches
{
    public class HandlerExplosionStartPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(HandlerExplosion), nameof(HandlerExplosion.Start));
        }

        [PatchPostfix]
        private static void Postfix(HandlerExplosion __instance)
        {
            __instance.gameObject.SetActive(false);
        }
    }
}
