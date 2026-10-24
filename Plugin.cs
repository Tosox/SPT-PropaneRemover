using BepInEx;
using Tosox.PropaneRemover.Patches;

namespace Tosox.PropaneRemover
{
    [BepInPlugin("com.pein.propaneremover", PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        internal const string PluginName = "Pein's Propane Remover";
        internal const string PluginVersion = "1.1.0";
        internal const string PluginAuthor = "pein, Tosox";
        internal const string PluginSource = "https://github.com/Tosox/SPT-PropaneRemover";

        internal void Awake()
        {            
            new HandlerExplosionStartPatch().Enable();

            Logger.LogInfo("Plugin loaded successfully");
        }
    }
}
