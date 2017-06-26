using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerPrefs : MonoBehaviour {

    private void Awake()
    {
        if (PlayerPrefs.GetString("music") == "")
            PlayerPrefs.SetString("music", "ON");
        if (PlayerPrefs.GetString("sound") == "")
            PlayerPrefs.SetString("sound", "ON");
    }

    public void ToggleMusic()
    {
        if (PlayerPrefs.GetString("music") == "ON")
            SetMusicOff();
        else
            SetMusicOn();
    }

    public void ToggleSound()
    {
        if (PlayerPrefs.GetString("sound") == "ON")
            SetSoundOff();
        else
            SetSoundOn();
    }

    private void SetMusicOn()
    {
        PlayerPrefs.SetString("music", "ON");
    }
    private void SetMusicOff()
    {
        PlayerPrefs.SetString("music", "OFF");
    }
    private void SetSoundOn()
    {
        PlayerPrefs.SetString("sound", "ON");
    }
    private void SetSoundOff()
    {
        PlayerPrefs.SetString("sound", "OFF");
    }

}
