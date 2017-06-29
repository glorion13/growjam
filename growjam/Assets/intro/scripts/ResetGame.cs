using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour {

	// Use this for initialization
	private void OnEnable () {
        PlayerPrefs.SetInt("continue", 0);
    }
}
