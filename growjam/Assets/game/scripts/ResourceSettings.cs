using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSettings : MonoBehaviour {

    public Wither WitherMechanics;

    public int MinWater;
    public int MaxWater;

    public int MinSunlight;
    public int MaxSunlight;

    public int MinHeat;
    public int MaxHeat;

    public float LowThreshold;
    public float HighThreshold;

    private void Update()
    {
        CheckWithering();
    }

    private void Start()
    {
        SetResourceLimits();
    }

    private void SetResourceLimits()
    {
        if (Resources.GetMaxWater() == 0)
            Resources.SetMaxWater(MaxWater);
        else
            MaxWater = Resources.GetMaxWater();

        if (Resources.GetMaxSunlight() == 0)
            Resources.SetMaxSunlight(MaxSunlight);
        else
            MaxSunlight = Resources.GetMaxSunlight();

        if (Resources.GetMaxHeat() == 0)
            Resources.SetMaxHeat(MaxHeat);
        else
            MaxHeat = Resources.GetMaxHeat();
    }

    private void CheckWithering()
    {
        if (Resources.GetWater() <= MinWater)
        {
            Resources.SetWater(MinWater);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetWater() >= MaxWater)
        {
            Resources.SetWater(MaxWater);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetSunlight() <= MinSunlight)
        {
            Resources.SetSunlight(MinSunlight);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetSunlight() >= MaxSunlight)
        {
            Resources.SetSunlight(MaxSunlight);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetHeat() <= MinHeat)
        {
            Resources.SetHeat(MinHeat);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetHeat() >= MaxHeat)
        {
            Resources.SetHeat(MaxHeat);
            WitherMechanics.IsWithering = true;
        }
        else
        {
            WitherMechanics.IsWithering = false;
        }
    }

}
