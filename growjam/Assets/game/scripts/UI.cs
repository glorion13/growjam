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

    public GameObject WaterMutationPanel;
    public GameObject SunlightMutationPanel;
    public GameObject HeatMutationPanel;

    public GameObject WaterMutationUpgradePanel;
    public GameObject SunlightMutationUpgradePanel;
    public GameObject HeatMutationUpgradePanel;

    public Text WaterRate;
    public Text SunlightRate;
    public Text HeatRate;

    public Color Low;
    public Color Medium;
    public Color High;

    public void OpenWaterMutationPanel()
    {
        WaterMutationPanel.SetActive(true);
    }
    public void CloseWaterMutationPanel()
    {
        WaterMutationPanel.SetActive(false);
    }
    public void OpenSunlightMutationPanel()
    {
        SunlightMutationPanel.SetActive(true);
    }
    public void CloseSunlightMutationPanel()
    {
        SunlightMutationPanel.SetActive(false);
    }
    public void OpenHeatMutationPanel()
    {
        HeatMutationPanel.SetActive(true);
    }
    public void CloseHeatMutationPanel()
    {
        HeatMutationPanel.SetActive(false);
    }

    public void OpenWaterMutationUpgradePanel()
    {
        if (WaterMutationUpgradePanel.activeSelf)
        {
            CloseWaterMutationUpgradePanel();
        }
        else
        {
            CloseSunlightMutationUpgradePanel();
            CloseHeatMutationUpgradePanel();
            WaterMutationUpgradePanel.SetActive(true);
        }
    }
    public void CloseWaterMutationUpgradePanel()
    {
        WaterMutationUpgradePanel.SetActive(false);
    }
    public void OpenSunlightMutationUpgradePanel()
    {
        if (SunlightMutationUpgradePanel.activeSelf)
        {
            CloseSunlightMutationUpgradePanel();
        }
        else
        {
            CloseWaterMutationUpgradePanel();
            CloseHeatMutationUpgradePanel();
            SunlightMutationUpgradePanel.SetActive(true);
        }
    }
    public void CloseSunlightMutationUpgradePanel()
    {
        SunlightMutationUpgradePanel.SetActive(false);
    }

    public void OpenHeatMutationUpgradePanel()
    {
        if (HeatMutationUpgradePanel.activeSelf)
        {
            CloseHeatMutationUpgradePanel();
        }
        else
        {
            CloseWaterMutationUpgradePanel();
            CloseSunlightMutationUpgradePanel();
            HeatMutationUpgradePanel.SetActive(true);
        }
    }
    public void CloseHeatMutationUpgradePanel()
    {
        HeatMutationUpgradePanel.SetActive(false);
    }

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

    private void ActivateWaterMutation()
    {

    }

    private void UpdateWaterUI()
    {
        WaterProgress.fillAmount = (float)(Resources.GetWater() - ResourceSettings.MinWater) / (float)(ResourceSettings.MaxWater - ResourceSettings.MinWater);

        if (Resources.WaterRate > 0)
            WaterRate.text = "+" + Resources.WaterRate.ToString();
        else
            WaterRate.text = Resources.WaterRate.ToString();

        if (WaterProgress.fillAmount <= ResourceSettings.LowThreshold)
        {
            WaterProgress.color = Low;
            CloseWaterMutationPanel();
        }
        else if (WaterProgress.fillAmount >= ResourceSettings.HighThreshold)
        {
            WaterProgress.color = High;
            OpenWaterMutationPanel();
        }
        else
        {
            WaterProgress.color = Medium;
            CloseWaterMutationPanel();
        }
    }

    private void UpdateSunlightUI()
    {
        SunlightProgress.fillAmount = (float) (Resources.GetSunlight() - ResourceSettings.MinSunlight) / (float) (ResourceSettings.MaxSunlight - ResourceSettings.MinSunlight);

        if (Resources.SunlightRate > 0)
            SunlightRate.text = "+" + Resources.SunlightRate.ToString();
        else
            SunlightRate.text = Resources.SunlightRate.ToString();

        if (SunlightProgress.fillAmount <= ResourceSettings.LowThreshold)
        {
            SunlightProgress.color = Low;
            CloseSunlightMutationPanel();
        }
        else if (SunlightProgress.fillAmount >= ResourceSettings.HighThreshold)
        {
            SunlightProgress.color = High;
            OpenSunlightMutationPanel();
        }
        else
        {
            SunlightProgress.color = Medium;
            CloseSunlightMutationPanel();
        }
    }

    private void UpdateHeatUI()
    {
        HeatProgress.fillAmount = (float) (Resources.GetHeat() - ResourceSettings.MinHeat) / (float) (ResourceSettings.MaxHeat - ResourceSettings.MinHeat);

        if (Resources.HeatRate > 0)
            HeatRate.text = "+" + Resources.HeatRate.ToString();
        else
            HeatRate.text = Resources.HeatRate.ToString();

        if (HeatProgress.fillAmount <= ResourceSettings.LowThreshold)
        {
            HeatProgress.color = Low;
            CloseHeatMutationPanel();
        }
        else if (HeatProgress.fillAmount >= ResourceSettings.HighThreshold)
        {
            HeatProgress.color = High;
            OpenHeatMutationPanel();
        }
        else
        {
            HeatProgress.color = Medium;
            CloseHeatMutationPanel();
        }
    }

}
