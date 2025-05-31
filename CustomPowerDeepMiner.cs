using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace CustomPowerDeepMiner
{
    [BepInPlugin("CustomPowerDeepMiner", "Custom Power DeepMiner", "0.0.3.0")]   
    public class CustomPowerDeepMinerPlugin : BaseUnityPlugin
    {
        public static CustomPowerDeepMinerPlugin Instance;


        public void Log(string line)
        {
            Debug.Log("[CustomPowerDeepMiner]: " + line);
        }

        private void Awake()
        {
            CustomPowerDeepMinerPlugin.Instance = this;
            Log("Hello World");

            try
            {
                // Harmony.DEBUG = true;
                ConfigFile.HandleConfig(this);     // read (or create) the configuration file parameters
                var harmony = new Harmony("net.ThndrDev.stationeers.CustomPowerDeepMiner.Scripts");
                harmony.PatchAll();
                Log("Patch succeeded");
            }
            catch (Exception e)
            {
                Log("Patch Failed");
                Log(e.ToString());
            }
        }
    }
}