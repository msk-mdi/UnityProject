using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vie : MonoBehaviour
{
    public float vie1 = 100;
    public GameObject voiture;
    public float vi;

    // Update is called once per frame
    void Update()
    {

        if (Physics.Raycast(transform.position, -Vector3.up, out RaycastHit hiti))
        {
            vi = hiti.collider.gameObject.GetComponent<Zonedegat>().vie2;
        }
        vie1 -= vi * Time.deltaTime;
        if (vie1 < 0)
        {
            Destroy(voiture);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision " + collision.collider.name);
        if (collision.collider.CompareTag("Balle"))
        {
            vie1 -= 10;
        }
    }
}