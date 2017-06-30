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

    public static void SetMaxWater(int value)
    {
        PlayerPrefs.SetInt("maxWater", value);
    }
    public static void SetMaxSunlight(int value)
    {
        PlayerPrefs.SetInt("maxSunlight", value);

    }
    public static void SetMaxHeat(int value)
    {
        PlayerPrefs.SetInt("maxHeat", value);
    }

    public static int GetMaxWater()
    {
        return PlayerPrefs.GetInt("maxWater");
    }
    public static int GetMaxSunlight()
    {
        return PlayerPrefs.GetInt("maxSunlight");
    }
    public static int GetMaxHeat()
    {
        return PlayerPrefs.GetInt("maxHeat");
    }

    public static void AddMaxWater(int value)
    {
        PlayerPrefs.SetInt("maxWater", GetMaxWater() + value);
    }
    public static void AddMaxSunlight(int value)
    {
        PlayerPrefs.SetInt("maxSunlight", GetMaxSunlight() + value);
    }
    public static void AddMaxHeat(int value)
    {
        PlayerPrefs.SetInt("maxHeat", GetMaxHeat() + value);
    }

}
