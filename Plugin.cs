using BepInEx;
using SPTPropaneRemover.Patches;

namespace SPTPropaneRemover
{
    [BepInPlugin("com.pein.propaneremover", PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        internal const string PluginName = "Propane Remover";
        internal const string PluginVersion = "1.1.0";
        internal const string PluginAuthor = "pein";
        internal const string PluginSource = "https://github.com/Tosox/SPT-PropaneRemover";

        internal void Awake()
        {            
            new HandlerExplosionStartPatch().Enable();

            Logger.LogInfo("Plugin loaded successfully");
        }
    }
}
