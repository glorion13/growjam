using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSettings : MonoBehaviour {

    public int MinWater;
    public int MaxWater;

    public int MinSunlight;
    public int MaxSunlight;

    public int MinHeat;
    public int MaxHeat;

    public float LowThreshold;
    public float HighThreshold;

    private void Update()
    {
        if (Resources.GetWater() < MinWater)
            Resources.SetWater(MinWater);
        if (Resources.GetWater() > MaxWater)
            Resources.SetWater(MaxWater);

        if (Resources.GetSunlight() < MinSunlight)
            Resources.SetSunlight(MinSunlight);
        if (Resources.GetSunlight() > MaxSunlight)
            Resources.SetSunlight(MaxSunlight);

        if (Resources.GetHeat() < MinHeat)
            Resources.SetHeat(MinHeat);
        if (Resources.GetHeat() > MaxHeat)
            Resources.SetHeat(MaxHeat);
    }

}
