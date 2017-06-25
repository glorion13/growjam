using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressIntro : MonoBehaviour {

    public Text[] TextList;
    private int currentTextIndex;

    private void Start()
    {
        currentTextIndex = 0;
    }

    public void Progress()
    {
        TextList[currentTextIndex].gameObject.SetActive(false);
        currentTextIndex++;
        if (currentTextIndex < TextList.Length)
            TextList[currentTextIndex].gameObject.SetActive(true);
        else
            SceneManager.LoadScene("game");
    }
}
