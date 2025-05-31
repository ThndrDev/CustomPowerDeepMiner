using BepInEx.Configuration;

using UnityEngine;

namespace CustomPowerDeepMiner
{
    internal class ConfigFile
    {
        private static ConfigEntry<float> configDeepminerPowerUsage;

        public static float DeepminerPowerUsage;

        public static void HandleConfig(CustomPowerDeepMinerPlugin cpd) // Create and manage the configuration file parameters
        {
            configDeepminerPowerUsage = cpd.Config.Bind("0 - General configuration",
             "DeepminerPowerUsage",
             5000f,
             "Set how much power deepminer will draw when active. Needs to be a number between 1 and 100000, vanilla power consumption is 500.");
            DeepminerPowerUsage = Mathf.Clamp(configDeepminerPowerUsage.Value, 1, 100000);
        }

    }
}
