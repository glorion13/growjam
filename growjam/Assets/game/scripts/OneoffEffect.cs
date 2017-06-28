using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneoffEffect : MonoBehaviour {

    public int WaterBonus;
    public int SunlightBonus;
    public int HeatBonus;

    public void Trigger()
    {
        Resources.AddWater(WaterBonus);
        Resources.AddSunlight(SunlightBonus);
        Resources.AddHeat(HeatBonus);
    }
}
