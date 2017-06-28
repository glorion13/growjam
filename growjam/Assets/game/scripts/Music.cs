using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

    public GameObject MusicSource;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetString("music") == "OFF")
        {
            MusicSource.SetActive(false);
        }
    }

}
