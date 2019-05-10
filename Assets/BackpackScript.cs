using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackScript : MonoBehaviour {

    public GameObject backpackOne;
    public GameObject backpackTwo;
    public GameObject backpackThree;

    public Transform PanelBackpacks;

    public void BackpackOne()
    {
        backpackOne.SetActive(true);
        backpackTwo.SetActive(false);
        backpackThree.SetActive(false);

        PanelBackpacks.gameObject.SetActive(false);
    }

    public void BackpackTwo()
    {
        backpackOne.SetActive(false);
        backpackTwo.SetActive(true);
        backpackThree.SetActive(false);

        PanelBackpacks.gameObject.SetActive(false);
    }

    public void BackpackThree()
    {
        backpackOne.SetActive(false);
        backpackTwo.SetActive(false);
        backpackThree.SetActive(true);

        PanelBackpacks.gameObject.SetActive(false);
    }

}
