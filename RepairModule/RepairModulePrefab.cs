﻿using System.Collections.Generic;
using SMLHelper.V2.Crafting;
using Common;

namespace RepairModule
{
    internal class RepairModulePrefab : CraftableModItem
    {
        public static TechType TechTypeID { get; private set; }

        internal RepairModulePrefab()
            : base(nameID: "RepairModule",
                  iconFileName: "RepairModule",
                  iconTechType: TechType.None,
                  friendlyName: "Repair Module",
                  description: "Allows to repair damaged Vehicles from inside.",
                  template: TechType.SeamothSonarModule,
                  fabricatorType: CraftTree.Type.SeamothUpgrades,
                  fabricatorTab: new string[] { "CommonModules" },
                  requiredAnalysis: TechType.BaseUpgradeConsole,
                  groupForPDA: TechGroup.VehicleUpgrades,
                  categoryForPDA: TechCategory.VehicleUpgrades,
                  equipmentType: EquipmentType.VehicleModule,
                  quickSlotType: QuickSlotType.Toggleable,
                  backgroundType: CraftData.BackgroundType.Normal,
                  itemSize: new Vector2int(1, 1),
                  gamerResourceFileName: null
                  )
        {
        }
               
        public override void Patch()
        {
            base.Patch();            
            TechTypeID = TechType;
            
        }
        
        protected override TechData GetRecipe()
        {
            return new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>(new Ingredient[2]
                {
                    new Ingredient(TechType.Welder, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 1)                    
                })
            };
        }
    }
}
