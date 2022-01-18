using HarmonyLib;
using UnityEngine;

namespace NoIntro
{
    public static class NoIntroPatches
    {
        [HarmonyPatch(typeof(StartupScene), "Update")]
        [HarmonyPrefix]
        private static void StartupScene_Update_Prefix(StartupScene __instance,
            GameObject ___startupAnimationObject)
        {
            __instance.animationLength = 0f;
            ___startupAnimationObject.SetActive(false);
        }
    }
}
