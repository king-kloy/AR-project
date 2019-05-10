using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour {

    public Transform PanelWelcome;
    public Transform PanelFootwears;
    public Transform PanelBackpacks;

    public void showFootwearsPanel()
    {
        PanelWelcome.gameObject.SetActive(false);
        PanelFootwears.gameObject.SetActive(true);
        PanelBackpacks.gameObject.SetActive(false);
    }

    public void showBackpacksPanel()
    {
        PanelWelcome.gameObject.SetActive(false);
        PanelFootwears.gameObject.SetActive(false);
        PanelBackpacks.gameObject.SetActive(true);
    }

    public void HomeButton()
    {
        PanelWelcome.gameObject.SetActive(true);
        PanelFootwears.gameObject.SetActive(false);
        PanelBackpacks.gameObject.SetActive(false);
    }

    public void OpenUrl()
    {
        Application.OpenURL("www.tonaton.com");
    }
}
