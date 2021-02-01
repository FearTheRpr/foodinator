using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeButton : MonoBehaviour
{
    public GameObject userMenu;
    public GameObject welcomeMenu;
    public GameObject adultMenu;
    public GameObject KidsMenu;
    public GameObject retrieveFood;

    public void welcomeScreen()
    {
        welcomeMenu.SetActive(false);
        userMenu.SetActive(true);
    }

    public void grownUpMenu()
    {
        userMenu.SetActive(false);
        adultMenu.SetActive(true);

    }

    public void kidsMenu()
    {
        userMenu.SetActive(false);
        KidsMenu.SetActive(true);

    }

    /*/public void foodRetrieval()
    {
        adultMenu.SetActive(false);
        KidsMenu.SetActive(false);
        


    }/*/
}
