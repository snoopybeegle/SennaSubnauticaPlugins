﻿using UnityEngine;

namespace CheatManager
{
    internal class WarpTargets
    {
        internal Vector3 ConvertStringPosToVector3(string target)
        {
            string[] numbers = target.Split(' ');            
            return new Vector3(float.Parse(numbers[0]), float.Parse(numbers[1]), float.Parse(numbers[2]));
        }        

        public readonly string[][] Targets = new string[][]
        {
            new string[] { "0 0 0",           "Safe Shallows"},
            new string[] { "0 500 0",         "Bungee Jumping (500m)"},
            new string[] { "0 1000 0",        "Bungee Jumping (1000m)"},
            new string[] { "-710 0 -1075",    "Floating Island"},
            new string[] { "378 8 1114",      "Gun Island"},
            new string[] { "-841 -860 418",   "Tree Cove (Lost River)"},
            new string[] { "-594 -740 -72",   "Bones Field (Lost River)"},
            new string[] { "420 132 1185",    "TopGun"},
            new string[] { "349 158 906",     "HillTop"},
            new string[] { "0 -3050 0",       "Underworld"},
            new string[] { "-486 -500 1326",  "Lifepod 2 (Blood Kelp Two)"},
            new string[] { "-24 -15 409",     "Lifepod 3 (Kelp Forest)"},
            new string[] { "710 -5 152",      "Lifepod 4 (Crash Zone)"},
            new string[] { "370 -108 306",    "Lifepod 6 (Grassy Plateaus)"},
            new string[] { "-50 -170 -1036",  "Lifepod 7 (Crag Field)"},
            new string[] { "1103 -256 562",   "Lifepod 12 (Koosh Zone)"},
            new string[] { "-918 -166 504",   "Lifepod 13 (Mushroom Forest)"},
            new string[] { "-513 -83 -57",    "Lifepod 17 (Grassy Plateaus)"},
            new string[] { "-816 -292 -877",  "Lifepod 19 (Sparse Reef Deep)"},
            new string[] { "285 -70 444",     "Wreck 1 (Grassy Plateaus)"},
            new string[] { "-690 -85 -35",    "Wreck 2 (Grassy Plateaus)"},
            new string[] { "929 -200 598",    "Wreck 3 (Koosh Zone)"},
            new string[] { "-78 -188 847",    "Wreck 4 (Underwater Islands)"},
            new string[] { "740 -346 1220",   "Wreck 5 (Mountains)"},
            new string[] { "-1448 -332 723",  "Wreck 6 (Dunes)"},
            new string[] { "-1148 -166 -706", "Wreck 7 (Sea Treader Path)"},
            new string[] { "-1223 -346 -356", "Wreck 8 (Blood Kelp Trench)"},
            new string[] { "-672 -113 750",   "Wreck 9 (Mushroom Forest)"},
            new string[] { "-290 -222 -773",  "Wreck 10 (Grand Reef)"},
            new string[] { "-865 -430 -1390", "Wreck 11 (Grand Reef)"},
            new string[] { "-393 -112 630",   "Wreck 12 (Grassy Plateaus)"},
            new string[] { "-15 -96 -624",    "Wreck 13 (Grassy Plateaus)"},
            new string[] { "-418 -94 -261",   "Wreck 14 (Grassy Plateaus)"},
            new string[] { "-33 -25 -398",    "Wreck 15 (Safe Shallows)"},
            new string[] { "343 -16 -190",    "Wreck 16 (Safe Shallows)"},
            new string[] { "64 -24 376",      "Wreck 17 (Kelp Forest)"},
            new string[] { "-317 -73 222",    "Wreck 18 (Kelp Forest)"},
            new string[] { "1060 -266 1353",  "Wreck 19 (Mountains)"},
            new string[] { "-805 -209 -718",  "Wreck 20 (Sparse Reef)"},
            new string[] { "1145 0 142",      "Aurora Entry Point"},
            new string[] { "-772 17 -1109",   "Degasi Base 1 (Floating Island)"},
            new string[] { "-804 79 -1053",   "Degasi Base 1a (Floating Island)"},
            new string[] { "-703 77 -1163",   "Degasi Base 1b (Floating Island)"},
            new string[] { "87 -262 -357",    "Degasi Base 2 (Jellyshroom Caves)"},
            new string[] { "-632 -500 -934",  "Degasi Base 3 (Deep Grand Reef)"},
            new string[] { "343 64 902",      "Precursor Gate: Mountains to Floating Island"},
            new string[] { "170 -1428 -367",  "Precursor Gate: Prison to Crag Field"},
            new string[] { "190 -1428 -405",  "Precursor Gate: Prison to Lost River: Ghost Tree"},
            new string[] { "333 -1428 -276",  "Precursor Gate: Prison to Koosh Zone"},
            new string[] { "353 -1428 -314",  "Precursor Gate: Prison to Mushroom Forest"},
            new string[] { "248 -1588 -316",  "Precursor Gate: Prison Aquarium to Gun Outer"},
            new string[] { "-35 -1212 113",   "Precursor Gate: Lava Castle to Gun Inner"},
            new string[] { "386 -90 1137",    "Precursor Gate: Gun Inner"},
            new string[] { "-662 5 -1077",    "Precursor Gate: Floating Island"},
            new string[] { "-943 -620 1019",  "Precursor Gate: Lost River: Ghost Tree"},
            new string[] { "1383 -298 762",   "Precursor Gate: Koosh Zone"},
            new string[] { "-803 -227 408",   "Precursor Gate: Mushroom Forest"},
            new string[] { "-80 -290 -1363",  "Precursor Gate: Crag Field"},
            new string[] { "-222 -791 320",   "Precursor Base (Lost River)"},
            new string[] { "-32 -1201 66",    "Precursor Base (Lava Castle)"},
            new string[] { "210 -1448 -250",  "Precursor Prison (Lava Lakes)"},
            new string[] { "-1112 -684 -653", "Precursor Cave (Lost River: Skeleton Cave)"},
            new string[] { "-882 -305 -786",  "Precursor Cache (Sparse Reef)"},
            new string[] { "-1182 -378 1128", "Precursor Cache (Dunes)"},
            new string[] { "-596 -555 1480",  "Precursor Cache (Blood Kelp Two)"}            
        };        
    }
}
