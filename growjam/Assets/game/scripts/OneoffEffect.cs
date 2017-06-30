using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneoffEffect : MonoBehaviour {

    public int WaterBonus;
    public int SunlightBonus;
    public int HeatBonus;

    public int MaxWaterBonus;
    public int MaxSunlightBonus;
    public int MaxHeatBonus;

    public void Trigger()
    {
        Resources.AddWater(WaterBonus);
        Resources.AddSunlight(SunlightBonus);
        Resources.AddHeat(HeatBonus);

        Resources.AddMaxWater(MaxWaterBonus);
        Resources.AddMaxSunlight(MaxSunlightBonus);
        Resources.AddMaxHeat(MaxHeatBonus);

        Debug.Log(Resources.GetMaxWater() + MaxWaterBonus);
    }
}
