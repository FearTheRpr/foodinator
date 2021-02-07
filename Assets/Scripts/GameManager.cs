using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject userMenu;
    public GameObject welcomeMenu;
    public GameObject adultMenu;
    public GameObject KidsMenu;
    public Animator Animation;



    public void welcomeScreen()
    {
        
            StartCoroutine(Text());

            IEnumerator Text()
            {

                Animation.SetBool("trigger", true);

                yield return new WaitForSeconds(1.0f);
                Animation.SetBool("trigger", false);
            welcomeMenu.SetActive(false);
            userMenu.SetActive(true);
        }
        
       
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




}
