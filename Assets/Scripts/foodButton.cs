using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodButton : MonoBehaviour
{

    public GameObject plateOfFood;

    public void makeFoodAppear()
    {
        plateOfFood.SetActive(true);
    }
}
