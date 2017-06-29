using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour {

    public int StartingWater;
    public int StartingSunlight;
    public int StartingHeat;

	private void Start () {
        bool IsNewGame = PlayerPrefs.GetInt("continue") == 0;
        if (IsNewGame)
        {
            Resources.SetWater(StartingWater);
            Resources.SetSunlight(StartingSunlight);
            Resources.SetHeat(StartingHeat);

            PlayerPrefs.SetInt("continue", 1);
        }
	}
}
