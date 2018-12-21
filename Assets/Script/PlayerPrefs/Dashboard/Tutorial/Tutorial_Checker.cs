using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Checker : MonoBehaviour {


    public GameObject tutorial;
    public GameObject tutorial_lower;

    void Start () {

        if (PlayerPrefs.GetString("tutorial") == "Deactive" && PlayerPrefs.GetString("tutorial_2") == "Deactive")
        {
           

            if (Screen.width > 1280)
            {
                tutorial.SetActive(true);
                tutorial_lower.SetActive(false);
            }
            else
            {
                tutorial.SetActive(false);
                tutorial_lower.SetActive(true);
            }
        }
        else
        {
  

            if (Screen.width > 1280)
            {
                tutorial.SetActive(false);
                tutorial_lower.SetActive(false);
            }
            else
            {
                tutorial.SetActive(false);
                tutorial_lower.SetActive(false);
            }
        }

        
    }

    public void exit_tutorial()
    {
        PlayerPrefs.SetString("crafting_reward_binary", "Completed");
        PlayerPrefs.SetString("tutorial", "Active");
        PlayerPrefs.SetInt("Pl_coin",75);
        PlayerPrefs.SetInt("Player_id", 1);
        PlayerPrefs.SetInt("Binary_rain", 5);
        tutorial.SetActive(false);
        tutorial_lower.SetActive(false);
        Debug.Log("hello worldsss");
    }

}
