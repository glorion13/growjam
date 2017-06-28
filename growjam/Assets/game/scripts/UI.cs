using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public GameObject EventPanel;
    public GameObject EvolutionsPanel;

    public Text EventTitle;
    public Text EventText;

    public Image WaterProgress;
    public Image SunlightProgress;
    public Image HeatProgress;

    public Text WaterRate;
    public Text SunlightRate;
    public Text HeatRate;

    public Color Low;
    public Color Medium;
    public Color High;

    public float LowThreshold;
    public float HighThreshold;

    private float timescale;

    private void Update()
    {
        UpdateResourcesUI();
    }

    public void Pause()
    {
        timescale = Time.timeScale;
        Time.timeScale = 0;
    }
    public void UnPause()
    {
        Time.timeScale = timescale;
    }

    public void OpenEventPanel(string title, string text)
    {
        EventTitle.text = title;
        EventText.text = text;
        EventPanel.SetActive(true);
    }

    private void UpdateResourcesUI()
    {
        UpdateWaterUI();
        UpdateSunlightUI();
        UpdateHeatUI();
    }

    private void UpdateWaterUI()
    {
        WaterProgress.fillAmount = Resources.GetWater() / 100f;

        if (Resources.WaterRate > 0)
            WaterRate.text = "+" + Resources.WaterRate.ToString();
        else
            WaterRate.text = Resources.WaterRate.ToString();

        if (WaterProgress.fillAmount <= LowThreshold)
            WaterProgress.color = Low;
        else if (WaterProgress.fillAmount >= HighThreshold)
            WaterProgress.color = High;
        else
            WaterProgress.color = Medium;
    }

    private void UpdateSunlightUI()
    {
        SunlightProgress.fillAmount = Resources.GetSunlight() / 100f;

        if (Resources.SunlightRate > 0)
            SunlightRate.text = "+" + Resources.SunlightRate.ToString();
        else
            SunlightRate.text = Resources.SunlightRate.ToString();

        if (SunlightProgress.fillAmount <= LowThreshold)
            SunlightProgress.color = Low;
        else if (SunlightProgress.fillAmount >= HighThreshold)
            SunlightProgress.color = High;
        else
            SunlightProgress.color = Medium;
    }

    private void UpdateHeatUI()
    {
        HeatProgress.fillAmount = Resources.GetHeat() / 100f;

        if (Resources.HeatRate > 0)
            HeatRate.text = "+" + Resources.HeatRate.ToString();
        else
            HeatRate.text = Resources.HeatRate.ToString();

        if (HeatProgress.fillAmount <= LowThreshold)
            HeatProgress.color = Low;
        else if (HeatProgress.fillAmount >= HighThreshold)
            HeatProgress.color = High;
        else
            HeatProgress.color = Medium;
    }

}
