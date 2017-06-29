using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionsDeck : Tickable
{
    public override void Tick()
    {
        foreach (Evolution evolution in GetComponentsInChildren<Evolution>())
        {
            evolution.Tick();
        }
    }
}
