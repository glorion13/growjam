using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSettings : MonoBehaviour {

    public Wither WitherMechanics;

    public int MaxWater;
    public int MaxSunlight;
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
        if (Resources.GetWater() <= 0)
        {
            Resources.SetWater(0);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetWater() >= Resources.GetMaxWater())
        {
            Resources.SetWater(Resources.GetMaxSunlight());
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetSunlight() <= 0)
        {
            Resources.SetSunlight(0);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetSunlight() >= Resources.GetMaxSunlight())
        {
            Resources.SetSunlight(Resources.GetMaxSunlight());
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetHeat() <= 0)
        {
            Resources.SetHeat(0);
            WitherMechanics.IsWithering = true;
        }
        else if (Resources.GetHeat() >= Resources.GetMaxHeat())
        {
            Resources.SetHeat(Resources.GetMaxHeat());
            WitherMechanics.IsWithering = true;
        }
        else
        {
            WitherMechanics.IsWithering = false;
        }
    }

}
