using EFT.GameTriggers;
using HarmonyLib;
using SPT.Reflection.Patching;
using System.Reflection;
using UnityEngine;

namespace SPTPropaneRemover.Patches
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
            GameObject go = __instance.gameObject;
            
            go.SetActive(false);
        }
    }
}
