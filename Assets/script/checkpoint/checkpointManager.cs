using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private int nombre_checkpoint;
    public Checkpoint checkp;
    public List<Checkpoint> checkpoint_list;
    public GameObject car;

    void Update()
    {
        bool check = true;
        if (checkpoint_list.Count <= 0)
        {
            check = false;
        }
        foreach (Checkpoint checkpoint in checkpoint_list)
        {
            check = check && checkpoint.car_passé;
        }
        if (check)
        {
            nombre_checkpoint += 1;
            Debug.Log(nombre_checkpoint + Time.deltaTime);
            foreach (Checkpoint checkpoint in checkpoint_list)
            {
                checkpoint.car_passé = false;
            }
        }

        if (nombre_checkpoint == 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
