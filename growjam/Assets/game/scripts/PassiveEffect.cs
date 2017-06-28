using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveEffect : Tickable {

    public int WaterRate;
    public int SunlightRate;
    public int HeatRate;

    private void OnEnable()
    {
        Resources.WaterRate += WaterRate;
        Resources.SunlightRate += SunlightRate;
        Resources.HeatRate += HeatRate;
    }

    private void OnDisable()
    {
        Resources.WaterRate -= WaterRate;
        Resources.SunlightRate -= SunlightRate;
        Resources.HeatRate -= HeatRate;
    }

    public override void Tick()
    {
        Resources.AddWater(WaterRate);
        Resources.AddSunlight(SunlightRate);
        Resources.AddHeat(HeatRate);
    }
}
