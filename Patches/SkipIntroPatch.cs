using HarmonyLib;
using UnityEngine;
using SMU.Reflection;
namespace NoIntro
{
    public static class NoIntroPatches
    {
        [HarmonyPatch(typeof(StartupScene), "Update")]
        [HarmonyPrefix]
        private static void StartupScene_Update_Prefix(StartupScene __instance)
        {
            __instance.animationLength = 0f;
            __instance.GetField<StartupScene, GameObject>("startupAnimationObject").SetActive(false);
        }

    } 
}
