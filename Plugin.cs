using BepInEx;
using HarmonyLib;

namespace NoIntro
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            // Init logs and patches.
            var harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll(typeof(NoIntroPatches));
        }
    }
}

