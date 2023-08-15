using HarmonyLib;

namespace LBoL_Sideloader_Template1
{
    public static class PluginInfo
    {
        // each loaded plugin needs to have a unique GUID. usually author+generalCategory+Name is good enough
        public const string GUID = "reale.lbol.loctweaks";
        public const string Name = "Lost Branch of Localization";
        public const string version = "1.0.0";
        public static readonly Harmony harmony = new Harmony(GUID);

    }
}
