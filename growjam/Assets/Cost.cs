using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost : MonoBehaviour {

    private OneoffEffect costEffect;
    private Button button;

    // Update is called once per frame
    private void Start()
    {
        costEffect = GetComponent<OneoffEffect>();
        button = GetComponent<Button>();
    }

	void Update ()
    {
        if (Resources.GetWater() < Mathf.Abs(costEffect.WaterBonus))
        {
            if (costEffect.WaterBonus < 0)
            {
                button.interactable = false;
            }
        }
        else if (Resources.GetSunlight() < Mathf.Abs(costEffect.SunlightBonus))
        {
            if (costEffect.SunlightBonus < 0)
            {
                button.interactable = false;
            }
        }
        else if (Resources.GetHeat() < Mathf.Abs(costEffect.HeatBonus))
        {
            if (costEffect.HeatBonus < 0)
            {
                button.interactable = false;    
            }
        }
        else
            button.interactable = true;
    }
}
