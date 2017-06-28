using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDeck : Tickable {

    public int TriggerIntervalInTicks;
    public float TriggerChance;

    public UI UI;

    private Event[] events;
    private int ticks;

    private void Start()
    {
        events = GetComponentsInChildren<Event>(true);
    }

    public override void Tick()
    {
        ticks++;
        if (ticks >= TriggerIntervalInTicks)
        {
            ticks = 0;
            if (isEventTriggered())
            {
                Event triggeredEvent = getRandomEvent(events);

                UI.Pause();
                UI.OpenEventPanel(triggeredEvent.Title, triggeredEvent.Text);
            }
        }
    }

    private bool isEventTriggered()
    {
        float roll = UnityEngine.Random.Range(0, 100);
        return roll <= TriggerChance;
    }

    private Event getRandomEvent(Event[] events)
    {
        int randomEventIndex = UnityEngine.Random.Range(0, events.Length - 1);
        return events[randomEventIndex];
    }
}
