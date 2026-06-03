using HarmonyLib;

namespace DisableCalamities
{
    [HarmonyPatch(typeof(EncounterCollection), "GetRandomEncounter")]
    internal class Patch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
