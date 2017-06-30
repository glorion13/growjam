using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour {

	// Use this for initialization
	private void OnEnable () {
        PlayerPrefs.SetInt("continue", 0);
        Resources.SetMaxWater(0);
        Resources.SetMaxSunlight(0);
        Resources.SetMaxHeat(0);
    }
}
