﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodButton : MonoBehaviour
{

    public GameObject plateOfFood;
    public GameObject currentMenu;
    public GameObject foodRetrieval;


    public void makeFoodAppear()
    {
        plateOfFood.SetActive(true);
        currentMenu.SetActive(false);
        foodRetrieval.SetActive(true);

    }
}
