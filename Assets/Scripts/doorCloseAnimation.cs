using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCloseAnimation : MonoBehaviour
{
    public Animator Animation;

    public void closeDoor()

    {
        StartCoroutine(Text());

        IEnumerator Text()
        {

            Animation.SetBool("trigger", true);

            yield return new WaitForSeconds(0.5f);
            Animation.SetBool("trigger", false);

        }
    }
}
