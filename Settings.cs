using UnityModManagerNet;

namespace SteamCutOff
{
    public class Settings : UnityModManager.ModSettings, IDrawable
    {
        [Draw("Reset Cutoff Key")]
        public KeyBinding resetKey = new KeyBinding() { keyCode = UnityEngine.KeyCode.F8 };

        public void OnChange()
        {
        }

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
    }
}
