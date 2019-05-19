﻿using Harmony;
using Common;
using SlotExtender.Configuration;

namespace SlotExtender.Patchers
{
    [HarmonyPatch(typeof(Exosuit))]
    [HarmonyPatch("slotIDs", MethodType.Getter)]
    internal class Exosuit_slotIDs_Patch
    {
        [HarmonyPrefix]
        internal static bool Prefix(ref string[] __result)
        {
            //__result = SlotHelper.ExpandedExosuitSlotIDs;
            __result = SlotHelper.SessionExosuitSlotIDs;
            return false;
        }
    }    

    [HarmonyPatch(typeof(Exosuit))]
    [HarmonyPatch("Start")]
    internal class Exosuit_Start_Patch
    {
        [HarmonyPostfix]
        internal static void Postfix(Exosuit __instance)
        {            
            __instance.gameObject.AddIfNeedComponent<SlotExtender>();
            SNLogger.Log($"[{SEConfig.PROGRAM_NAME}] Added component to instance: {__instance.name} ID: {__instance.GetInstanceID()}");           
        }
    }
}
