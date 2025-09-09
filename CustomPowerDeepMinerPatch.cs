using HarmonyLib;
using JetBrains.Annotations;
using UnityEngine;
using Assets.Scripts.Objects.Pipes;

namespace CustomPowerDeepMiner
{
    [HarmonyPatch(typeof(DeepMiner))]
    public static class DeepMinerPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        [UsedImplicitly]

        static private void ChangeDeepminerPowerPatch(DeepMiner __instance) 
        {
            __instance.UsedPower = ConfigFile.DeepminerPowerUsage;
        }
    }
}
