using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    // collider => pour rouler
    [SerializeField] WheelCollider front_right;
    [SerializeField] WheelCollider front_left;
    [SerializeField] WheelCollider back_right;
    [SerializeField] WheelCollider back_left;

    // transform => pour voir les roues tourner
    [SerializeField] Transform front_right_transform;
    [SerializeField] Transform front_left_transform;
    [SerializeField] Transform back_right_transform;
    [SerializeField] Transform back_left_transform;

    // si arme touche terrain => restart last checkpoint
    [SerializeField] BoxCollider weapon;
    [SerializeField] MeshCollider terrain;

    // max 
    private float max_vitesse = 1000f;
    private float max_frein = 300f;
    private float max_angle = 15f;

    public float current_vitesse = 0f;
    private float current_frein = 0f;
    private float current_angle = 0f;

    private void FixedUpdate()
    {
        current_vitesse = max_vitesse * Input.GetAxis("Vertical");

        // frein
        if (Input.GetKey(KeyCode.Space))
        {
            current_frein = max_frein;
        }
        else
        {
            current_frein = 0f;
        }

        // (avancer | reculer) sur les 2 roues avant
        front_right.motorTorque = current_vitesse;
        front_left.motorTorque = current_vitesse;

        // frein sur les 4 roues
        front_right.brakeTorque = current_frein;
        front_left.brakeTorque = current_frein;
        back_right.brakeTorque = current_frein;
        back_left.brakeTorque = current_frein;

        // tourner
        current_angle = max_angle * Input.GetAxis("Horizontal");
        front_left.steerAngle = current_angle;
        front_right.steerAngle = current_angle;

        // collider status => transform status
        Update_Wheel(front_left, front_left_transform);
        Update_Wheel(front_right, front_right_transform);
        Update_Wheel(back_left, back_left_transform);
        Update_Wheel(back_right, back_right_transform);

        void Update_Wheel(WheelCollider collid, Transform transf)
        {
            // collider status
            Vector3 posi;
            Quaternion rota;
            collid.GetWorldPose(out posi, out rota);

            // collider status => transform status
            transf.position = posi;
            transf.rotation = rota;
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(0);
        }
    }
}