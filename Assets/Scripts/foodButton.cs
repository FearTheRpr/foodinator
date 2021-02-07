using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodButton : MonoBehaviour
{

    public GameObject plateOfFood;
    public GameObject currentMenu;
    public GameObject foodRetrieval;
    public GameObject welcome;


    public void makeFoodAppear()
    {
        plateOfFood.SetActive(true);
        currentMenu.SetActive(false);
        foodRetrieval.SetActive(true);

    }

    public void machineReset()
    {
        foodRetrieval.SetActive(false);
        welcome.SetActive(true);

    }
}
