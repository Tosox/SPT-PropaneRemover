using BepInEx;
using BepInEx.Logging;
using SPTPropaneRemover.Patches;

namespace SPTPropaneRemover
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;

        private void Awake()
        {
            Logger = base.Logger;
            
            new HandlerExplosionStartPatch().Enable();
        }
    }
}
