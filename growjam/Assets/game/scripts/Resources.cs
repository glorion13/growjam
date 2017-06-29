using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Resources {

    public static int WaterRate = 0;
    public static int SunlightRate = 0;
    public static int HeatRate = 0;

    public static void SetWater(int value)
    {
        PlayerPrefs.SetInt("water", value);
    }
    public static void SetSunlight(int value)
    {
        PlayerPrefs.SetInt("sunlight", value);

    }
    public static void SetHeat(int value)
    {
        PlayerPrefs.SetInt("heat", value);
    }

    public static void AddWater(int value)
    {
        PlayerPrefs.SetInt("water", GetWater() + value);
    }
    public static void AddSunlight(int value)
    {
        PlayerPrefs.SetInt("sunlight", GetSunlight() + value);
    }
    public static void AddHeat(int value)
    {
        PlayerPrefs.SetInt("heat", GetHeat() + value);
    }

    public static int GetWater()
    {
        return PlayerPrefs.GetInt("water");
    }
    public static int GetSunlight()
    {
        return PlayerPrefs.GetInt("sunlight");
    }
    public static int GetHeat()
    {
        return PlayerPrefs.GetInt("heat");
    }

}
