using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticker : MonoBehaviour {

    public List<Tickable> Tickables;
    public float TickInterval;

    private void Start()
    {
        InvokeRepeating("Tick", 0, TickInterval);
    } 

    private void Tick()
    {
        foreach (Tickable tickable in Tickables)
            tickable.Tick();
    }

}
