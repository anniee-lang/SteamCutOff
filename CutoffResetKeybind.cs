using DV.Simulation.Controllers;
using DV.HUD;

namespace SteamCutOff
{
    public static class CutoffResetKeybind
    {
        public static void ResetCutoffToNeutral()
        {
            var car = PlayerManager.Car;
            if (car == null) return;

            var controls = car.GetComponentsInChildren<OverridableBaseControl>(true);
            foreach (var control in controls)
            {
                if (control.ControlType == InteriorControlsManager.ControlType.Reverser)
                {
                    control.MUOverride(0.5f);
                    return;
                }
            }
        }
    }
}
