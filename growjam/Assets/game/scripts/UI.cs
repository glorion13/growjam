using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public GameObject EventPanel;
    public GameObject GameOverPanel;
    public GameObject WitheringWarning;

    public ResourceSettings ResourceSettings;

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

    private float timescale;

    private void Update()
    {
        UpdateResourcesUI();
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void UnPause()
    {
        Time.timeScale = 1f;
    }

    public void OpenGameOverPanel()
    {
        HideWitheringWarning();
        Pause();
        GameOverPanel.SetActive(true);
    }

    public void ShowWitheringWarning()
    {
        if (EventPanel.activeSelf) return;
        if (GameOverPanel.activeSelf) return;
        WitheringWarning.SetActive(true);
    }
    public void HideWitheringWarning()
    {
        WitheringWarning.SetActive(false);
    }

    public void OpenEventPanel(string title, string text)
    {
        Debug.Log("1");
        HideWitheringWarning();
        Debug.Log("2");
        Pause();
        EventTitle.text = title;
        EventText.text = text;
        EventPanel.SetActive(true);
    }

    public void CloseEventPanel()
    {
        UnPause();
        EventPanel.SetActive(false);
    }

    private void UpdateResourcesUI()
    {
        UpdateWaterUI();
        UpdateSunlightUI();
        UpdateHeatUI();
    }

    private void UpdateWaterUI()
    {
        WaterProgress.fillAmount = (float) (Resources.GetWater() - ResourceSettings.MinWater) / (float) (ResourceSettings.MaxWater - ResourceSettings.MinWater);

        if (Resources.WaterRate > 0)
            WaterRate.text = "+" + Resources.WaterRate.ToString();
        else
            WaterRate.text = Resources.WaterRate.ToString();

        if (WaterProgress.fillAmount <= ResourceSettings.LowThreshold)
            WaterProgress.color = Low;
        else if (WaterProgress.fillAmount >= ResourceSettings.HighThreshold)
            WaterProgress.color = High;
        else
            WaterProgress.color = Medium;
    }

    private void UpdateSunlightUI()
    {
        SunlightProgress.fillAmount = (float) (Resources.GetSunlight() - ResourceSettings.MinSunlight) / (float) (ResourceSettings.MaxSunlight - ResourceSettings.MinSunlight);

        if (Resources.SunlightRate > 0)
            SunlightRate.text = "+" + Resources.SunlightRate.ToString();
        else
            SunlightRate.text = Resources.SunlightRate.ToString();

        if (SunlightProgress.fillAmount <= ResourceSettings.LowThreshold)
            SunlightProgress.color = Low;
        else if (SunlightProgress.fillAmount >= ResourceSettings.HighThreshold)
            SunlightProgress.color = High;
        else
            SunlightProgress.color = Medium;
    }

    private void UpdateHeatUI()
    {
        HeatProgress.fillAmount = (float) (Resources.GetHeat() - ResourceSettings.MinHeat) / (float) (ResourceSettings.MaxHeat - ResourceSettings.MinHeat);

        if (Resources.HeatRate > 0)
            HeatRate.text = "+" + Resources.HeatRate.ToString();
        else
            HeatRate.text = Resources.HeatRate.ToString();

        if (HeatProgress.fillAmount <= ResourceSettings.LowThreshold)
            HeatProgress.color = Low;
        else if (HeatProgress.fillAmount >= ResourceSettings.HighThreshold)
            HeatProgress.color = High;
        else
            HeatProgress.color = Medium;
    }

}
