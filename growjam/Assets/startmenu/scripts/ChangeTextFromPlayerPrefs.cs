using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextFromPlayerPrefs : MonoBehaviour
{
    public Text Text;
    public string Key;
    public string Pretext;

    private void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        string uiText = Pretext + PlayerPrefs.GetString(Key);
        Text.text = uiText;
    }
}
