using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.WebRequestMethods;
using UnityEngine.SceneManagement;

public class Loading_Scene : MonoBehaviour
{
   // public GameObject Internet_Panel;
   // public GameObject Loading_Scene_Obj;
   // public int Load_int;
    public Image LoadBar;
    float Timing, Second;
    void Start()
    {
        Second = 2;
        // 
    }

    public void Load_Scene()
    {
       // Loading_Scene_Obj.SetActive(false);
        //SoundManager.instance.Bg_Music_Toggel(false);
       // SoundManager.instance.Sound_B.isOn = false;
    }

    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
          //  Internet_Panel.SetActive(true);
            Debug.Log("Error. Check internet connection!");
        }

        else if (Timing < 2)
        {
           // if (Load_int == 0)
           // {
                Invoke("Load_Scene", 2f);
           //     Load_int = 1;
           // }

            Timing += Time.deltaTime;
            LoadBar.fillAmount = Timing / Second;
           // Internet_Panel.SetActive(false);
        }
    }
    public void Check_Internet_Available()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Error. Check internet connection!");
           // StartCoroutine(checkInternetConnection((isConnected) => Scene_Change()));
        }
        else
        {
           // Internet_Panel.SetActive(false);
        }

    }
    public void Scene_Change()
    {
       // Internet_Panel.SetActive(false);
       // SceneManager.LoadScene(0);

    }
}


