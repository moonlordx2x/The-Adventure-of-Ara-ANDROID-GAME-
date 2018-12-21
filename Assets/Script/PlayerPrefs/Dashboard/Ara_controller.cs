using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ara_controller : MonoBehaviour {


    public GameObject suit_default;
    public GameObject suit_cplus;
    public GameObject suit_java;
    public GameObject suit_php;

    void Update () {
        //Debug.Log(PlayerPrefs.GetInt("Player_id"));

        if (PlayerPrefs.GetInt("Player_id") == 1)
        { 
            //Debug.Log("Default");

            suit_default.SetActive(true);
            suit_cplus.SetActive(false);
            suit_java.SetActive(false);
            suit_php.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Player_id") == 2)
        {   
            suit_default.SetActive(false);
            suit_cplus.SetActive(true);
            suit_java.SetActive(false);
            suit_php.SetActive(false);

            //Debug.Log("Cplus");
        }
        else if (PlayerPrefs.GetInt("Player_id") == 3)
        {
            suit_default.SetActive(false);
            suit_cplus.SetActive(false);
            suit_java.SetActive(true);
            suit_php.SetActive(false);

           // Debug.Log("Java");
        }
        else if (PlayerPrefs.GetInt("Player_id") == 4)
        {
            suit_default.SetActive(false);
            suit_cplus.SetActive(false);
            suit_java.SetActive(false);
            suit_php.SetActive(true);

         //   Debug.Log("PHP");
        }
    }
}
