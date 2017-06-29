using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wither : Tickable {

    public int WitherCountdownInTicks;
    public bool IsWithering;

    public UI UI;

    public GameObject Plant;

    private void VisualiseWithering(GameObject plant)
    {
        float newAlpha = AlphaBasedOnTicks();
        WitherSprite(plant.GetComponent<SpriteRenderer>(), newAlpha);
        foreach (SpriteRenderer child in plant.GetComponentsInChildren<SpriteRenderer>())
        {
            if (child != null)
                WitherSprite(child, newAlpha);
        }
    }

    private void RestoreWitheringEffect(GameObject plant)
    {
        WitherSprite(plant.GetComponent<SpriteRenderer>(), 1f);
    }

    private float AlphaBasedOnTicks()
    {
        return 1f - ((float) ticks * (1f / WitherCountdownInTicks));
    }

    private void WitherSprite(SpriteRenderer spriteRenderer, float alpha)
    {
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
    }

    private int ticks;
    public override void Tick()
    {
        if (IsWithering)
        {
            ticks++;
            UI.ShowWitheringWarning();
            VisualiseWithering(Plant);
            if (ticks >= WitherCountdownInTicks)
            {
                UI.OpenGameOverPanel();
            }
        }
        else
        {
            ticks = 0;
            UI.HideWitheringWarning();
            RestoreWitheringEffect(Plant);
        }
    }
}
