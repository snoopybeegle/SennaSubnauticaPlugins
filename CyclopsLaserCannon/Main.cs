﻿using System;
using System.Reflection;
using Harmony;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Common;
using UWE;
using MoreCyclopsUpgrades.Managers;
using MoreCyclopsUpgrades.CyclopsUpgrades;

using static Common.GameHelper;
using SMLHelper.V2.Utility;

namespace CyclopsLaserCannonModule
{
    public static class Main
    {
        public static AssetBundle assetBundle;
        public static Material cannon_material;
        public static Sprite buttonSprite;

        public static bool isAssetsLoaded;
        public static UpgradeHandler upgradeHandler;
        //Used MCU Events
        public static UpgradeEvent onFinishedUpgrades;
        //public static UpgradeAllowedEvent isAllowedToAdd;
        //public static UpgradeAllowedEvent isAllowedToRemove;
        public static UpgradeEvent onClearUpgrades;

        public static Event<string> onConfigurationChanged = new Event<string>();

        public static void Load()
        {
            try
            {
                isAssetsLoaded = LoadAssets();

                CannonConfig.InitConfig();

                var laserCannon = new CannonPrefab();

                laserCannon.Patch();

                HarmonyInstance.Create("Subnautica.CyclopsLaserCannonModule.mod").PatchAll(Assembly.GetExecutingAssembly());

                SceneManager.sceneLoaded += new UnityAction<Scene, LoadSceneMode>(OnSceneLoaded);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }

            try
            {
                UpgradeManager.RegisterReusableHandlerCreator(() =>
                {
                    upgradeHandler = new UpgradeHandler(CannonPrefab.TechTypeID)
                    {
                        MaxCount = 1,
                        //IsAllowedToAdd = isAllowedToAdd,
                        //IsAllowedToRemove = isAllowedToRemove,
                        OnFinishedUpgrades = onFinishedUpgrades,
                        OnClearUpgrades = onClearUpgrades
                    };

                    return upgradeHandler;
                });
            }
            catch
            {
                SNLogger.Log("[CyclopsLaserCannonModule] MCU UpgradeManager initialization failed!");
            }
        }

        private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (scene.name == "StartScreen")
            {
                Language.main.OnLanguageChanged += CannonConfig.OnLanguageChanged;
            }
        }

        private static bool LoadAssets()
        {
            try
            {
                assetBundle = AssetBundle.LoadFromFile("./QMods/CyclopsLaserCannonModule/Assets/laser_sounds");                

                Texture2D cannon_Button = ImageUtils.LoadTextureFromFile("./QMods/CyclopsLaserCannonModule/Assets/cannon_Button.png");

                buttonSprite = Sprite.Create(cannon_Button, new Rect(0, 0, cannon_Button.width, cannon_Button.height), new Vector2(cannon_Button.width * 0.5f, cannon_Button.height * 0.5f));

                cannon_material = GetResourceMaterial("worldentities/doodads/precursor/precursorteleporter", "precursor_interior_teleporter_02_01", 0);
                
                cannon_material.name = "cannon_material";

                return true;
            }
            catch
            {
                SNLogger.Log("[CyclopsLaserCannon] Warning! Loading assets failed!");
                return false;
            }
        }
    }     
}