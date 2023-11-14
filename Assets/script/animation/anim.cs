using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator mourir;
    public Animator distance2;
    public bool vrai1;

    public void distance(float distance1)
    {
        distance2.SetFloat("distance", distance1);
        vrai1 = true;
    }
    public void mourir1()
    {
        mourir.SetTrigger("mourir");
    }
}
