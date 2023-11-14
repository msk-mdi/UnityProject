using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuiviePlayer : MonoBehaviour
{
    //Utilser sur le gameObejt invisible pour bouger la direction
    public Rigidbody rigi;
    public GameObject po;
    Vector3 distance;
    float distance1;
    public float vitesse;
    public Transform visuelPersonnage;
    public float vue;
    public anim anim1;
    public anim anim2;
    public float despawn;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        distance = po.transform.position - gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(gameObject.transform.position, distance* 200, out RaycastHit hit))
        {
            direction = hit.point - gameObject.transform.position;
            direction.y = 0;
            visuelPersonnage.forward = direction;
        }

        Vector3 cami = po.transform.position - distance;
        Vector3 gr = Vector3.Lerp(gameObject.transform.position, cami, vue);
        distance = Vector3.Lerp(distance, Vector3.zero, vue);

        gameObject.transform.position = gr;

        distance1 = Vector3.Distance(gameObject.transform.position, po.transform.position);
        anim2.distance(distance1);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision " + collision.collider.name);
        if (collision.collider.CompareTag("Balle"))
        {
            anim1.mourir1();
            Destroy(gameObject, despawn);
        }
    }
}
