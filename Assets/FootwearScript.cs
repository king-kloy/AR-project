using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootwearScript : MonoBehaviour
{

    public GameObject shoe;
    public GameObject sneaker;
    public GameObject slipper;

    public Transform PanelFootwears;

    public void Shoe()
    {
        shoe.SetActive(true);
        sneaker.SetActive(false);
        slipper.SetActive(false);

        PanelFootwears.gameObject.SetActive(false);
    }

    public void Sneaker()
    {
        shoe.SetActive(false);
        sneaker.SetActive(true);
        slipper.SetActive(false);

        PanelFootwears.gameObject.SetActive(false);
    }

    public void Slipper()
    {
        shoe.SetActive(false);
        sneaker.SetActive(false);
        slipper.SetActive(true);

        PanelFootwears.gameObject.SetActive(false);
    }
}
