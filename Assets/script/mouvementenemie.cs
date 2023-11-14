using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementenemie : MonoBehaviour
{
    public Rigidbody rigi;
    public float vitesse;
    Vector3 distance;
    public float graviter = 20;
    public GameObject monObject;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        distance = monObject.transform.position - gameObject.transform.position;
        rigi.AddForce( distance.normalized * graviter);
    }
}
