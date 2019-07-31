﻿using System;
using System.Reflection;
using Harmony;
using UnityEngine;
using Common;

namespace ScannerModule
{
    public static class Main
    {
        public static void Load()
        {
            try
            {
                var scannermodule = new ScannerModulePrefab();
                scannermodule.Patch();

                HarmonyInstance.Create("Subnautica.ScannerModule.mod").PatchAll(Assembly.GetExecutingAssembly());                
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }
    }

    [HarmonyPatch(typeof(Vehicle))]
    [HarmonyPatch("OnUpgradeModuleChange")]    
    public class Vehicle_OnUpgradeModuleChange_Patch
    {
        static void Postfix(Vehicle __instance, int slotID, TechType techType, bool added)
        {
            if (techType == ScannerModulePrefab.TechTypeID && added)
            {
                if (__instance.GetType() == typeof(SeaMoth))
                {
                    var seamoth_control = __instance.gameObject.GetOrAddComponent<ScannerModuleSeamoth>();
                    seamoth_control.moduleSlotID = slotID;
                    return;
                }
                else if (__instance.GetType() == typeof(Exosuit))
                {
                    var exosuit_control = __instance.gameObject.GetOrAddComponent<ScannerModuleExosuit>();
                    exosuit_control.moduleSlotID = slotID - 2;
                    return;
                }
                else
                {
                    Debug.Log("[ScannerModule] Error! Unidentified Vehicle Type!");
                }
            }
        }
    }    
}
