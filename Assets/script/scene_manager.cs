using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_manager : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start_menu" + Time.time);
    }

    public void Start_game()
    {
        Debug.Log("LoadScene1" + Time.time);
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}