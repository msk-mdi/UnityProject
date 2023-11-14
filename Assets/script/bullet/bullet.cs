using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    public Rigidbody rigi;
    public float explosionRadius;
    public float explosionForce;
    public float vitesse;
    public vie vie;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        Destroy(gameObject, 1);
    }

    private void FixedUpdate()
    {
        rigi.velocity = transform.forward * vitesse;
    }

    private void OnColli(Collision col)
    {
        if (col.collider.tag == "ennemie")
        {
            Destroy(gameObject);
        }

        if (col.collider.tag == "Player")
        {
            vie.vie1 -= 10;
        }
    }
}