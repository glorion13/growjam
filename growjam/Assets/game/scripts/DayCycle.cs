using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCycle : Tickable
{
    public Image Background;

    private int ticks;
    public int DayDurationInTicks = 30;

    public override void Tick()
    {
        ticks++;
        if (ticks >= DayDurationInTicks)
        {
            ticks = 0;
            Debug.Log("changed");
        }
    }
}
