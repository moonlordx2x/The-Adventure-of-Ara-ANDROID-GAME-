using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Menu_Active_UI : MonoBehaviour {


    public GameObject cplus_ui;
    public GameObject java_ui;
    public GameObject php_ui;

    void Start () {
        cplus_ui.SetActive(false);
        java_ui.SetActive(false);
        php_ui.SetActive(false);

    }
	
	
	void Update () {

        if (PlayerPrefs.GetString("cplus_ui") == "active")
        {
            cplus_ui.SetActive(true);
        }
        else
        {
            cplus_ui.SetActive(false);
        }

        if (PlayerPrefs.GetString("java_ui") == "active")
        {
            java_ui.SetActive(true);
        }
        else
        {
            java_ui.SetActive(false);
        }

        if (PlayerPrefs.GetString("php_ui") == "active")
        {
            php_ui.SetActive(true);
        }
        else
        {
            php_ui.SetActive(false);
        }

    }
}
