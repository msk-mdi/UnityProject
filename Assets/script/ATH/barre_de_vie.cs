using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class barredevie : MonoBehaviour
{
    public Image image_vie;
    public vie vie2;
    public TMP_Text nombre;
    public Rigidbody car_rig;
    public Car car;

    public Image compteur_vitesse_image;
    public TMP_Text compteur_vitesse;

    // Update is called once per frame
    void FixedUpdate()
    {
        image_vie.fillAmount = vie2.vie1 / 100;
        nombre.text = vie2.vie1.ToString("f0");

        compteur_vitesse_image.fillAmount = car_rig.velocity.magnitude / car.current_vitesse;
        compteur_vitesse.text = car.current_vitesse.ToString("f0");

    }
}
