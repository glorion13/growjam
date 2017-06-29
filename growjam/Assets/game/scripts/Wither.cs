using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wither : Tickable {

    public int WitherCountdownInTicks;
    public bool IsWithering;

    private int ticks;
    public override void Tick()
    {
        if (IsWithering)
        {
            ticks++;
            Debug.Log("Withering... " + ticks.ToString());
            if (ticks >= WitherCountdownInTicks)
            {
                Debug.Log("You're dead!");
            }
        }
        else
        {
            ticks = 0;
        }
    }
}
