using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour {

    public int StartingWater = 10;
    public int StartingSunlight = 10;
    public int StartingHeat = 10;

    public void Reset()
    {
        ResetResources();
        ResetPlant();
    }

    private void ResetResources()
    {
        Resources.SetWater(StartingWater);
        Resources.SetSunlight(StartingSunlight);
        Resources.SetHeat(StartingHeat);
    }

    private void ResetPlant()
    {

    }

}
