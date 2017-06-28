using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCycle : Tickable
{
    public GameObject Background;

    private PassiveEffect activeEffect;

    public PassiveEffect dayEffect;
    public PassiveEffect nightEffect;

    private void Start()
    {
        activeEffect = dayEffect;
    }

    private int ticks;
    public int DayDurationInTicks = 30;
    private bool isNight = false;

    public override void Tick()
    {
        ticks++;
        if (isNight)
        {
            if (ticks >= (DayDurationInTicks / 2))
            {
                ticks = 0;
                isNight = false;
                Background.GetComponent<Animation>().Play("night-day", PlayMode.StopAll);
                dayEffect.gameObject.SetActive(true);
                nightEffect.gameObject.SetActive(false);
                activeEffect = dayEffect;
            }
        }
        else
        {
            if (ticks >= (DayDurationInTicks / 2))
            {
                ticks = 0;
                isNight = true;
                Background.GetComponent<Animation>().Play("day-night", PlayMode.StopAll);
                dayEffect.gameObject.SetActive(false);
                nightEffect.gameObject.SetActive(true);
                activeEffect = nightEffect;
            }
        }
        activeEffect.Tick();
    }
}
