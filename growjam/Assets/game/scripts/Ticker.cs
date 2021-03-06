﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticker : MonoBehaviour
{
    public List<Tickable> Tickables;

    public float TickRate;
    public static float TickInterval;

    private void Start()
    {
        TickInterval = TickRate;
        StartCoroutine(Tick());
    }

    private IEnumerator Tick()
    {
        while (true)
        {
            yield return new WaitForSeconds(TickInterval);
            foreach (Tickable tickable in Tickables)
                tickable.Tick();
        }
    }

    /*private IEnumerator Tick()
    {
        yield return new WaitForSeconds(waitInterval);

        while (true)
        {
            yield return new WaitForSeconds(RepeatInterval);
        }

    }*/
}