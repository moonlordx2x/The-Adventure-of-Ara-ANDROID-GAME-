using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager_Controller : MonoBehaviour {

    GameObject cplus_1x;
    GameObject cplus_2x;
    GameObject cplus_3x;

    void Start () {

        Debug.Log(PlayerPrefs.GetInt("cplus_1"));
        Debug.Log(PlayerPrefs.GetInt("cplus_2"));
        Debug.Log(PlayerPrefs.GetInt("cplus_3"));

        cplus_1x = GameObject.Find("C_world");
        cplus_2x = GameObject.Find("C_world (1)");
        cplus_3x = GameObject.Find("C_world (2)");


        if (PlayerPrefs.GetInt("cplus_2") == 1) { cplus_2x.SetActive(true); }
        else { cplus_2x.SetActive(false); }

        if (PlayerPrefs.GetInt("cplus_3") == 1) { cplus_3x.SetActive(true); }
        else { cplus_3x.SetActive(false); }

    }
	
	
}
