using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator Animation;

    public void openDoor()
    {
        StartCoroutine(Text());

        IEnumerator Text()
        {

            Animation.SetBool("Trigger", true);

            yield return new WaitForSeconds(0.5f);
            Animation.SetBool("Trigger", false);

        }
    }
 

}