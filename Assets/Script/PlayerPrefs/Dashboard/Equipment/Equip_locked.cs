using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip_locked : MonoBehaviour {

    public GameObject cplus_locked;
    public GameObject java_locked;
    public GameObject php_locked;

    void Start () {

        //cplus_locked.SetActive(false);
        //java_locked.SetActive(false);
        //php_locked.SetActive(false);

    }


    void Update() {

        if (PlayerPrefs.GetString("crafting_reward_cplus") == "Incompleted") {
            Debug.Log("C++ Incompleted");
            cplus_locked.SetActive(true);
        }
        else {
            Debug.Log("C++ Completed");
            cplus_locked.SetActive(false);
        }

        if (PlayerPrefs.GetString("crafting_reward_java") == "Incompleted") {
            Debug.Log("JAVA Incompleted");
            java_locked.SetActive(true);
        }
        else {
            Debug.Log("JAVA Completed");
            java_locked.SetActive(false);
        }

        if (PlayerPrefs.GetString("crafting_reward_php") == "Incompleted") {
            Debug.Log("PHP Incompleted");
            php_locked.SetActive(true);
        }
        else {
            Debug.Log("PHP Completed");
            php_locked.SetActive(false);
        }

    }
}
