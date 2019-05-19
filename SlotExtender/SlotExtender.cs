﻿using UnityEngine;
using UWE;
using SlotExtender.Configuration;
using Common;
using static Common.GameHelper;

namespace SlotExtender
{
    public class SlotExtender : MonoBehaviour
    {
        public SlotExtender Instance { get; private set; }
        private Vehicle ThisVehicle;
        private Player PlayerMain;
        private PDA PdaMain;
        internal bool isActive = false;        

        internal void Awake()
        {
            //get this SlotExtender instance
            Instance = GetComponent<SlotExtender>();

            if (Instance.GetComponent<SeaMoth>())
            {
                //this Vehicle type is SeaMoth
                ThisVehicle = Instance.GetComponent<SeaMoth>();

                //add extra slots
                foreach (string slotID in SlotHelper.NewSeamothSlotIDs)
                    ThisVehicle.modules.AddSlot(slotID);
            }
            else if (Instance.GetComponent<Exosuit>())
            {
                //this Vehicle type is Exosuit
                ThisVehicle = Instance.GetComponent<Exosuit>();

                //add extra slots
                foreach (string slotID in SlotHelper.NewExosuitSlotIDs)
                    ThisVehicle.modules.AddSlot(slotID);
            }
            else
            {
                SNLogger.Log($"[{SEConfig.PROGRAM_NAME}] Unknown Vehicle type error! Instance destroyed!");
                Destroy(Instance);
            }            
        }

        internal void Start()
        {    
            //get player instance
            PlayerMain = Player.main;
            PdaMain = PlayerMain.GetPDA();
            //forced triggering the Awake method in uGUI_Equipment for patching
            PdaMain.Open();
            PdaMain.Close();
            //add and start a handler to check the player mode if changed
            PlayerMain.playerModeChanged.AddHandler(this, new Event<Player.Mode>.HandleFunction(OnPlayerModeChanged));
            isActive = PlayerMain.GetVehicle() == ThisVehicle ? true : false;
        }        

        internal void OnPlayerModeChanged(Player.Mode playerMode)
        {
            if (playerMode == Player.Mode.LockedPiloting)
            {
                if (PlayerMain.GetVehicle() == ThisVehicle)
                {
                    //player in this Vehicle: this SlotExtender now enabled
                    isActive = true;
                }
                else
                {
                    //player not in this Vehicle: this Slot Extender now disabled
                    isActive = false;
                }
            }
            else
            {
                //player not in any Vehicle: this Slot Extender now disabled
                isActive = false;
            }
        }

        internal void Update()
        {
            if (!isActive)
                return; // Slot Extender not active. Exit method.

            if (Main.isConsoleActive)
                return; // Input console active. Exit method.

            if (Main.isKeyBindigsUpdate)
                return; // Keybindings changed and updating in progress. Exit method.

            if (!IsPlayerInVehicle())
                return; // Player not in any vehicle. Exit method.

            if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Upgrade"]))
            {
                if (PdaMain.isOpen)
                {
                    PdaMain.Close();
                    return;
                }                    
                else // Is Closed
                {
                    ThisVehicle.upgradesInput.OpenFromExternal();
                    return;
                }
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Storage"]))
            {
                if (ThisVehicle.GetType() != typeof(Exosuit))
                    return;
                if (PdaMain.isOpen)
                {
                    PdaMain.Close();
                    return;
                }
                else
                {
                    ThisVehicle.GetComponent<Exosuit>().storageContainer.Open();
                    return;
                }
            }
            else if (GameInput.GetButtonDown(GameInput.Button.Slot1))
            {
                if (ThisVehicle.GetType() != typeof(SeaMoth))
                    return;
                if (ThisVehicle.GetSlotBinding(0) != TechType.VehicleStorageModule)
                    return;
                if (PdaMain.isOpen)
                {
                    PdaMain.Close();
                    return;
                }
                else
                {
                    ThisVehicle.GetComponent<SeaMoth>().storageInputs[0].OpenFromExternal();
                    return;
                }
            }
            else if (GameInput.GetButtonDown(GameInput.Button.Slot2))
            {
                if (ThisVehicle.GetType() != typeof(SeaMoth))
                    return;
                if (ThisVehicle.GetSlotBinding(1) != TechType.VehicleStorageModule)
                    return;
                if (PdaMain.isOpen)
                {
                    PdaMain.Close();
                    return;
                }
                else
                {
                    ThisVehicle.GetComponent<SeaMoth>().storageInputs[1].OpenFromExternal();
                    return;
                }
            }
            else if (GameInput.GetButtonDown(GameInput.Button.Slot3))
            {
                if (ThisVehicle.GetType() != typeof(SeaMoth))
                    return;
                if (ThisVehicle.GetSlotBinding(2) != TechType.VehicleStorageModule)
                    return;
                if (PdaMain.isOpen)
                {
                    PdaMain.Close();
                    return;
                }
                else
                {
                    ThisVehicle.GetComponent<SeaMoth>().storageInputs[2].OpenFromExternal();
                    return;
                }
            }
            else if (GameInput.GetButtonDown(GameInput.Button.Slot4))
            {
                if (ThisVehicle.GetType() != typeof(SeaMoth))
                    return;
                if (ThisVehicle.GetSlotBinding(3) != TechType.VehicleStorageModule)
                    return;
                if (PdaMain.isOpen)
                {
                    PdaMain.Close();
                    return;
                }
                else
                {
                    ThisVehicle.GetComponent<SeaMoth>().storageInputs[3].OpenFromExternal();
                    return;
                }
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Slot_6"]))
            {
                ThisVehicle.SendMessage("SlotKeyDown", 5);
                return;
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Slot_7"]))
            {
                ThisVehicle.SendMessage("SlotKeyDown", 6);
                return;
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Slot_8"]))
            {
                ThisVehicle.SendMessage("SlotKeyDown", 7);
                return;
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Slot_9"]))
            {
                ThisVehicle.SendMessage("SlotKeyDown", 8);
                return;
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Slot_10"]))
            {
                ThisVehicle.SendMessage("SlotKeyDown", 9);
                return;
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Slot_11"]))
            {
                ThisVehicle.SendMessage("SlotKeyDown", 10);
                return;
            }
            else if (Input.GetKeyDown(SEConfig.KEYBINDINGS["Slot_12"]))
            {
                ThisVehicle.SendMessage("SlotKeyDown", 11);
                return;
            }
        }        

        public void OnDestroy()
        {
            //remove unused handler from memory
            PlayerMain.playerModeChanged.RemoveHandler(this, OnPlayerModeChanged);            
            Destroy(Instance);
        }
    }
}
