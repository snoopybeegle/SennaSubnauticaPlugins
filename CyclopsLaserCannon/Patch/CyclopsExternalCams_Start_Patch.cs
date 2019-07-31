﻿using Common;
using Harmony;
using UnityEngine;

namespace CyclopsLaserCannonModule.Patch
{
    [HarmonyPatch(typeof(CyclopsExternalCams))]
    [HarmonyPatch("Start")]
    public class CyclopsExternalCams_Start_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(CyclopsExternalCams __instance)
        {
            GameObject CyclopsRoot = __instance.transform.parent.gameObject;

            if (CyclopsRoot.name.Equals("__LIGHTMAPPED_PREFAB__"))
            {
                return;
            }            

            CyclopsRoot.AddIfNeedComponent<CannonControl>();

            SNLogger.Log($"[CyclopsLaserCannonModule] Patch injected on class [CyclopsExternalCams] for this Cyclops instance: {CyclopsRoot.GetInstanceID()}. CannonControl component added.");                       
        }
    }
}
