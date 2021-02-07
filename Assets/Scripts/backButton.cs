using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButton : MonoBehaviour
{

    public GameObject currentScreen;
    public GameObject previousScreen;

    public void Back()
    {
        currentScreen.SetActive(false);
        previousScreen.SetActive(true);

    }
}
