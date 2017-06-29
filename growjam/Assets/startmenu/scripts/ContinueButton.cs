using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour {

    public GameObject instantNewGameButton;
    public GameObject warningNewGameButton;

    public void Start()
    {
        if (PlayerPrefs.GetInt("continue") == 1)
        {
            gameObject.SetActive(true);
            instantNewGameButton.SetActive(false);
            warningNewGameButton.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
            instantNewGameButton.SetActive(true);
            warningNewGameButton.SetActive(false);
        }
    }

}
