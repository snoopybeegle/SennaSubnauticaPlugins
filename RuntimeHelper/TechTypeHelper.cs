﻿using System;
using System.Collections.Generic;
using static Common.GameHelper;

namespace RuntimeHelper
{
    public partial class RuntimeHelper
    {
        public List<TechTypeData> techTypeDatas = new List<TechTypeData>();

        public void InitFullTechTypeList(ref List<TechTypeData> TechTypeList)
        {
            int[] techTypeArray = (int[])Enum.GetValues(typeof(TechType));

            for (int i = 0; i < techTypeArray.Length; ++i)
            {
                TechType techType = (TechType)techTypeArray[i];

                if (TechType_Blacklist.Contains(techType))
                    continue;

                string name = Language.main.Get(TechTypeExtensions.AsString((TechType)techTypeArray[i], false));

                TechTypeList.Add(new TechTypeData(techType, name));
            }

            TechTypeList.Sort();
        }

        public static readonly List<TechType> TechType_Blacklist = new List<TechType>
        {
            TechType.Hoopfish,
            TechType.HoopfishSchool,
            TechType.AcidOld,
            TechType.Databox,
            TechType.BaseDoor,
            TechType.None,
            TechType.AcidMushroom,
            TechType.AcidMushroomSpore,
            TechType.AnalysisTreeOld,
            TechType.AquariumBlueprint,
            TechType.Audiolog,
            TechType.BarnacleSuckers,
            TechType.BaseBulkheadBlueprint,
            TechType.BaseMapRoomBlueprint,
            TechType.BaseObservatoryBlueprint,
            TechType.BasePlanterBlueprint,
            TechType.BaseRoomBlueprint,
            TechType.BaseUpgradeConsoleBlueprint,
            TechType.BaseWaterParkBlueprint,
            TechType.BatteryChargerBlueprint,
            TechType.BenchBlueprint,
            TechType.BikemanHullPlateBlueprintOld,
            TechType.BioreactorBlueprint,
            TechType.Biter,
            TechType.Bladderfish,
            TechType.BladderfishAnalysis,
            TechType.Bleeder,
            TechType.Blighter,
            TechType.BluePalmSeed,
            TechType.BoneShark,
            TechType.BonesharkEgg,
            TechType.BonesharkEggUndiscovered,
            TechType.Boomerang,
            TechType.BoomerangAnalysis,
            TechType.BrainCoral,
            TechType.BulboTree,
            TechType.CalciteOld,
            TechType.CarbonOld,
            TechType.CaveSkeleton,
            TechType.ConstructorBlueprint,
            TechType.CookedBladderfish,
            TechType.CookedBoomerang,
            TechType.CookedEyeye,
            TechType.CookedGarryFish,
            TechType.CookedHoleFish,
            TechType.CookedHoopfish,
            TechType.CookedHoverfish,
            TechType.CookedLavaBoomerang,
            TechType.CookedLavaEyeye,
            TechType.CookedOculus,
            TechType.CookedPeeper,
            TechType.CookedReginald,
            TechType.CookedSpadefish,
            TechType.CookedSpinefish,
            TechType.CoralOldPlaceholder,
            TechType.CountOld,
            TechType.CoveTree,
            TechType.Crabsnake,
            TechType.CrabsnakeEgg,
            TechType.CrabsnakeEggUndiscovered,
            TechType.CrabSquid,
            TechType.CrabsquidEgg,
            TechType.CrabsquidEggUndiscovered,
            TechType.Crash,
            TechType.CrashedShip,
            TechType.CrashEgg,
            TechType.CrashEggUndiscovered,
            TechType.Creepvine,
            TechType.CreepvinePiece,
            TechType.CreepvineSeedCluster,
            TechType.CuredBladderfish,
            TechType.CuredBoomerang,
            TechType.CuredEyeye,
            TechType.CuredGarryFish,
            TechType.CuredHoleFish,
            TechType.CuredHoopfish,
            TechType.CuredHoverfish,
            TechType.CuredLavaBoomerang,
            TechType.CuredLavaEyeye,
            TechType.CuredOculus,
            TechType.CuredPeeper,
            TechType.CuredReginald,
            TechType.CuredSpadefish,
            TechType.CuredSpinefish,
            TechType.CurrentGenerator,
            TechType.Cutefish,
            TechType.CutefishEgg,
            TechType.CutefishEggUndiscovered,
            TechType.Cyclops,
            TechType.CyclopsBlueprint,
            TechType.CyclopsBridgeBlueprint,
            TechType.CyclopsDockingBayBlueprint,
            TechType.CyclopsEngineBlueprint,
            TechType.CyclopsHullBlueprint,
            TechType.DevTestItemBlueprintOld,
            TechType.Drill,
            TechType.ExosuitBlueprint,
            TechType.EyesPlant,
            TechType.EyesPlantSeed,
            TechType.Eyeye,
            TechType.EyeyeAnalysis,
            TechType.FabricatorBlueprintOld,
            TechType.FarmingTrayBlueprint,
            TechType.FernPalm,
            TechType.FernPalmSeed,
            TechType.FiltrationMachineBlueprint,
            TechType.FlintOld,
            TechType.FragmentAnalyzerBlueprintOld,
            TechType.GabeSFeather,
            TechType.GabeSFeatherSeed,
            TechType.GarryFish,
            TechType.GarryFishAnalysis,
            TechType.Gasopod,
            TechType.GasopodEgg,
            TechType.GasopodEggUndiscovered,
            TechType.GasPod,
            TechType.GenericEgg,
            TechType.GhostLeviathan,
            TechType.GhostLeviathanJuvenile,
            TechType.GhostRayBlue,
            TechType.GhostRayRed,
            TechType.Grabcrab,
            TechType.GrandReefsEgg,
            TechType.GrassyPlateausEgg,
            TechType.HangingFruitTree,
            TechType.HangingStinger,
            TechType.HeatArea,
            TechType.HoleFish,
            TechType.HoleFishAnalysis,
            TechType.Hoopfish,
            TechType.HoopfishAnalysis,
            TechType.HoopfishSchool,
            TechType.Hoverfish,
            TechType.HoverfishAnalysis,
            TechType.HugeKoosh,
            TechType.HugeSkeleton,
            TechType.JellyPlant,
            TechType.JellyPlantSeed,
            TechType.Jellyray,
            TechType.JellyrayEgg,
            TechType.JellyrayEggUndiscovered,
            TechType.Jumper,
            TechType.JumperEgg,
            TechType.JumperEggUndiscovered,
            TechType.KelpForestEgg,
            TechType.KooshChunk,
            TechType.KooshZoneEgg,
            TechType.LargeFloater,
            TechType.LargeKoosh,
            TechType.LavaEyeye,
            TechType.LavaLarva,
            TechType.LavaLizard,
            TechType.LavaLizardEgg,
            TechType.LavaLizardEggUndiscovered,
            TechType.LavaZoneEgg,
            TechType.LEDLightBlueprint,
            TechType.LockerBlueprint,
            TechType.MedicalCabinetBlueprint,
            TechType.MediumKoosh,
            TechType.Melon,
            TechType.MelonPlant,
            TechType.MelonSeed,
            TechType.MembrainTree,
            TechType.MembrainTreeSeed,
            TechType.MembraneOld,
            TechType.Mesmer,
            TechType.MesmerEgg,
            TechType.MesmerEggUndiscovered,
            TechType.MonsterSkeleton,
            TechType.MoonpoolBlueprint,
            TechType.MushroomForestEgg,
            TechType.NuclearReactorBlueprint,
            TechType.ObservatoryOld,
            TechType.OculusAnalysis,
            TechType.Oculus,
            TechType.OrangeMushroom,
            TechType.OrangeMushroomSpore,
            TechType.OrangePetalsPlant,
            TechType.OrangePetalsPlantSeed,
            TechType.Peeper,
            TechType.PeeperAnalysis,
            TechType.PictureFrameBlueprint,
            TechType.PinkFlower,
            TechType.PinkFlowerSeed,
            TechType.PinkMushroom,
            TechType.PinkMushroomSpore,
            TechType.PlanterBoxBlueprint,
            TechType.PlanterPot2Blueprint,
            TechType.PlanterPot3Blueprint,
            TechType.PlanterPotBlueprint,
            TechType.PlanterShelfBlueprint,
            TechType.Player,
            TechType.PowerCellChargerBlueprint,
            TechType.PowerGeneratorOld,
            TechType.PowerTransmitterBlueprint,
            TechType.PrecursorFishSkeleton,
            TechType.PrecursorIonEnergyBlueprint,
            TechType.PrecursorLostRiverLabEgg,
            TechType.PrecursorPrisonAquariumIncubatorEggs,
            TechType.PrecursorPrisonLabEmperorEgg,
            TechType.PrecursorPrisonLabEmperorFetus,
            TechType.PrecursorSeaDragonSkeleton,
            TechType.PropulsionCannonBlueprint,
            TechType.PurpleBrainCoral,
            TechType.PurpleBrainCoralPiece,
            TechType.PurpleBranches,
            TechType.PurpleBranchesSeed,
            TechType.PurpleFan,
            TechType.PurpleFanSeed,
            TechType.PurpleRattle,
            TechType.PurpleRattleSpore,
            TechType.PurpleStalk,
            TechType.PurpleStalkSeed,
            TechType.PurpleTentacle,
            TechType.PurpleTentacleSeed,
            TechType.PurpleVasePlant,
            TechType.PurpleVasePlantSeed,
            TechType.PurpleVegetable,
            TechType.PurpleVegetablePlant,
            TechType.RabbitRay,
            TechType.RabbitrayEgg,
            TechType.RabbitrayEggUndiscovered,
            TechType.RadiationSuitBlueprint,
            TechType.RadioBlueprint,
            TechType.ReaperLeviathan,
            TechType.ReaperSkeleton,
            TechType.RedBasketPlant,
            TechType.RedBasketPlantSeed,
            TechType.RedBush,
            TechType.RedBushSeed,
            TechType.RedConePlant,
            TechType.RedConePlantSeed,
            TechType.RedGreenTentacle,
            TechType.RedGreenTentacleSeed,
            TechType.RedRollPlant,
            TechType.RedRollPlantSeed,
            TechType.Reefback,
            TechType.ReefbackAdvancedStructure,
            TechType.ReefbackBaby,
            TechType.ReefbackDNA,
            TechType.ReefbackEgg,
            TechType.ReefbackEggUndiscovered,
            TechType.ReefbackShell,
            TechType.ReefbackTissue,
            TechType.Reginald,
            TechType.ReginaldAnalysis,
            TechType.ReinforcedDiveSuitBlueprint,
            TechType.ReinforceHullBlueprint,
            TechType.RocketBase,
            TechType.RocketBaseLadder,
            TechType.RocketStage1,
            TechType.RocketStage2,
            TechType.RocketStage3,
            TechType.Rockgrub,
            TechType.RockPuncher,
            TechType.SafeShallowsEgg,
            TechType.Sandshark,
            TechType.SandsharkEgg,
            TechType.SandsharkEggUndiscovered,
            TechType.ScannerRoomBlueprint,
            TechType.SeaCrown,
            TechType.SeaCrownSeed,
            TechType.SeaDragon,
            TechType.SeaDragonSkeleton,
            TechType.SeaEmperor,
            TechType.SeaEmperorBaby,
            TechType.SeaEmperorJuvenile,
            TechType.SeaEmperorLeviathan,
            TechType.SeaglideBlueprint,
            TechType.SeamothBlueprint,
            TechType.SeaTreader,
            TechType.Shocker,
            TechType.ShockerEgg,
            TechType.ShockerEggUndiscovered,
            TechType.Shuttlebug,
            TechType.SignBlueprint,
            TechType.Skyray,
            TechType.SkyrayNonRoosting,
            TechType.SmallFan,
            TechType.SmallFanCluster,
            TechType.SmallFanSeed,
            TechType.SmallKoosh,
            TechType.SmallMelon,
            TechType.SnakeMushroom,
            TechType.SnakeMushroomSpore,
            TechType.SolarPanelBlueprint,
            TechType.Spadefish,
            TechType.SpadefishAnalysis,
            TechType.SpadefishEgg,
            TechType.SpadefishEggUndiscovered,
            TechType.SpecialHullPlateBlueprintOld,
            TechType.SpecimenAnalyzerBlueprint,
            TechType.SpikePlantSeed,
            TechType.SpineEel,
            TechType.Spinefish,
            TechType.SpinefishAnalysis,
            TechType.SpotlightBlueprint,
            TechType.SpottedLeavesPlant,
            TechType.SpottedLeavesPlantSeed,
            TechType.Stalker,
            TechType.StalkerEgg,
            TechType.StalkerEggUndiscovered,
            TechType.StarshipCargoCrateBlueprint,
            TechType.StarshipChairBlueprint,
            TechType.StarshipCircuitBoxBlueprint,
            TechType.StarshipDeskBlueprint,
            TechType.StarshipMonitorBlueprint,
            TechType.StasisRifleBlueprint,
            TechType.StillsuitBlueprint,
            TechType.TechlightBlueprint,
            TechType.TerraformerBlueprint,
            TechType.ThermalPlantBlueprint,
            TechType.TransfuserBlueprint,
            TechType.TreeMushroomPiece,
            TechType.TwistyBridgesEgg,
            TechType.Warper,
            TechType.WarperSpawner,
            TechType.WhiteMushroom,
            TechType.WhiteMushroomSpore,
            TechType.WorkbenchBlueprint,
            TechType.PrecursorLostRiverProductionLine,
            TechType.Accumulator,
            TechType.PrecursorPrisonAquariumFinalTeleporter,
            TechType.PrecursorPrisonAquariumPipe,
            TechType.AquariumFragment,
            TechType.HullReinforcementModule,
            TechType.HullReinforcementModule2,
            TechType.HullReinforcementModule3,
            TechType.BaseCorridor,
            TechType.BaseFoundation,
            TechType.AminoAcids,
            TechType.NuclearReactorFragment,
            TechType.BaseNuclearReactorFragment,
            TechType.CaveCrawler,
            TechType.BatteryAcidOld,
            TechType.PrecursorPipeRoomIncomingPipe,
            TechType.PlanterBoxFragment,
            TechType.StasisSphere,
            TechType.PrecursorLostRiverWarperParts,
            TechType.BaseBioReactorFragment,
            TechType.BioreactorFragment,
            TechType.PrecursorLostRiverLabBones,
            TechType.DiveSuit,
            TechType.StillsuitFragment,
            TechType.CombustibleOld,
            TechType.SeamothFragment,
            TechType.DolomiteOld,
            TechType.EatMyDictionHullPlateBlueprintOld,
            TechType.BatteryChargerFragment,
            TechType.BaseWaterParkFragment,
            TechType.EmeryOld,
            TechType.PowerCellChargerFragment,
            TechType.PrecursorEnergyCore,
            TechType.EnvironmentPlaceholder,
            TechType.EnyzmeCloud,
            TechType.BuildBot,
            TechType.BuilderFragment,
            TechType.PrecursorKeyTerminal,
            TechType.NuclearReactor,
            TechType.EthanolOld,
            TechType.EthyleneOld,
            TechType.CyclopsFabricator,
            TechType.SpecimenAnalyzerFragment,
            TechType.BaseWall,
            TechType.PlanterShelfFragment,
            TechType.LootSensorMetal,
            TechType.TechlightFragment,
            TechType.TreeMushroom,
            TechType.Graphene,
            TechType.GravSphereFragment,
            TechType.BulboTreePiece,
            TechType.BlueCoralTubes,
            TechType.Placeholder,
            TechType.ThermalPlantFragment,
            TechType.Thermometer,
            TechType.SandLoot,
            TechType.ConstructorFragment,
            TechType.FloatingStone,
            TechType.HydrogenOld,
            TechType.BaseCorridorI,
            TechType.BaseCorridorGlassI,
            TechType.PrecursorLabCacheContainer1,
            TechType.PrecursorLabCacheContainer2,
            TechType.PrecursorTeleporter,
            TechType.PrecursorThermalPlant,
            TechType.PrecursorSurfacePipe,
            TechType.PrecursorLabTable,
            TechType.PrecursorSensor,
            TechType.PrecursorScanner,
            TechType.PrecursorPrisonOutposts,
            TechType.PrecursorPrisonArtifact1,
            TechType.PrecursorPrisonArtifact2,
            TechType.PrecursorPrisonArtifact3,
            TechType.PrecursorPrisonArtifact4,
            TechType.PrecursorPrisonArtifact5,
            TechType.PrecursorPrisonArtifact6,
            TechType.PrecursorPrisonArtifact7,
            TechType.PrecursorPrisonArtifact8,
            TechType.PrecursorPrisonArtifact9,
            TechType.PrecursorPrisonArtifact10,
            TechType.PrecursorPrisonArtifact12,
            TechType.PrecursorPrisonArtifact13,
            TechType.TimeCapsule,
            TechType.Incubator,
            TechType.PrecursorPrisonAquariumIncubator,
            TechType.PrecursorPrisonIonGenerator,
            TechType.BaseMapRoom,
            TechType.BaseMapRoomFragment,
            TechType.BaseUpgradeConsoleFragment,
            TechType.ToyCar,
            TechType.BeaconFragment,
            TechType.Sign,
            TechType.SignFragment
        };
    }
}
