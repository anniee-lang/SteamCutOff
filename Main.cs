using UnityEngine;
using UnityModManagerNet;

namespace SteamCutOff
{
    public static class Main
    {
        public static Settings settings;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            settings = UnityModManager.ModSettings.Load<Settings>(modEntry);

            modEntry.OnGUI = OnGUI;
            modEntry.OnSaveGUI = OnSaveGUI;
            modEntry.OnUpdate = OnUpdate;

            return true;
        }

        static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            settings.Draw(modEntry);
        }

        static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            settings.Save(modEntry); 
        }

        static void OnUpdate(UnityModManager.ModEntry modEntry, float dt)
        {
            if (settings.resetKey.Down())
            {
                CutoffResetKeybind.ResetCutoffToNeutral();
            }
        }
    }
}
