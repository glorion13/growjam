using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckVictory : MonoBehaviour {

    public GameObject[] WinningUpgrades;
    public int NumberOfUpgradesToWin;

    public int CurrentUpgrades;
	
	// Update is called once per frame
	void Update () {
        CurrentUpgrades = 0;
        foreach (GameObject upgrade in WinningUpgrades)
        {
            if (upgrade.activeInHierarchy)
                CurrentUpgrades++;
        }
        if (CurrentUpgrades >= NumberOfUpgradesToWin)
        {
            SceneManager.LoadScene("victory");
        }
	}
}
