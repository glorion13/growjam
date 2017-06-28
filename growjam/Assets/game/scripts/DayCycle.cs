using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCycle : Tickable
{
    public GameObject Background;

    private OvertimeEffect enabledEffect;

    public OvertimeEffect dayEffect;
    public OvertimeEffect nightEffect;

    private void Start()
    {
        enabledEffect = dayEffect;
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
                enabledEffect = dayEffect;
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
                enabledEffect = nightEffect;
            }
        }
        enabledEffect.Trigger();
    }
}
