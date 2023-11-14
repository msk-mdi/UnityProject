using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Camera cam;
    public Transform positiondebase;
    public Transform monobject;

    void FixedUpdate()
    {
        cam.transform.position = positiondebase.transform.position;
    }
}