using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Launcher_ennemie : MonoBehaviour
{
    public Bullet bulletPrefab;
    public Transform spawnPoint;
    public float vitesse;
    public float timer;
    public anim anim1;
    public bool vrai;

    void Start()
    {
        timer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (vrai && timer < 0)
        {
            Bullet m = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            m.vitesse = vitesse;
            timer = 1;
        }
    }
}