﻿using Common;
using Harmony;

namespace SeamothEnergyShield
{
    [HarmonyPatch(typeof(SeaMoth))]
    [HarmonyPatch("Start")]
    public class SeaMoth_Start_Patch
    {
        [HarmonyPostfix]
        static void Postfix(SeaMoth __instance)
        {            
            __instance.gameObject.GetOrAddComponent<SeamothShieldControl>();           
        }
    }
}
