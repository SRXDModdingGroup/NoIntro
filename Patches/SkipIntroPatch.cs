using HarmonyLib;
using UnityEngine;

namespace NoIntro
{
    public static class NoIntroPatches
    {
        [HarmonyPatch(typeof(StartupScene), "Update")]
        [HarmonyPrefix]
        private static void StartupScene_Update_Prefix(StartupScene __instance,
            ref float ___m_fadeDuration, GameObject ___startupAnimationObject)
        {
            __instance.animationLength = 0f;
            ___m_fadeDuration = 0f;
            ___startupAnimationObject.SetActive(false);
        }

        [HarmonyPatch(typeof(StartupScene), "Start")]
        [HarmonyPostfix]
        private static void StartupScene_Start_Postfix(StartupScene __instance) {
            __instance.GetComponentInChildren<Camera>().backgroundColor = Color.black;
        }
    }
}
