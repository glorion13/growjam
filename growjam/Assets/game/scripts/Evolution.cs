using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evolution : Tickable {

    public float Cooldown;

    public Image ProgressBar;
    public Button Button;

    public OvertimeEffect PassiveEffect;
    public OneoffEffect ActiveEffect;

    public int Ticks;

    public void ResetTicks()
    {
        Ticks = 0;
        ProgressBar.fillAmount = (Ticks / Cooldown);
        Button.interactable = false;
    }

    public override void Tick()
    {
        Ticks++;
        ProgressBar.fillAmount = (Ticks / Cooldown);
        if (ProgressBar.fillAmount == 1)
            Button.interactable = true;
        else
            Button.interactable = false;
        PassiveEffect.Trigger();

    }
}
