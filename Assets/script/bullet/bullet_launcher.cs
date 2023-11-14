using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Launcher : MonoBehaviour
{
    public Bullet bulletPrefab;
    public Transform spawnPoint;
    public float vitesse;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Bullet m = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            m.vitesse = vitesse;
        }
    }
}