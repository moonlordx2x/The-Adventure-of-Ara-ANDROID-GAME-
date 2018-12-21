using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashboard_UI : MonoBehaviour {


    public GameObject dashboard;
    public GameObject dashboard_2;
    public GameObject dashboard_3;

    public GameObject cplus_platform;
    public GameObject java_platform;
    public GameObject php_platform;


    void Start () {
        dashboard.SetActive(false);
        dashboard_2.SetActive(false);
        dashboard_3.SetActive(false);

        cplus_platform.SetActive(false);
        java_platform.SetActive(false);
        php_platform.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetString("cplus_ui") == "active")
        {
            dashboard.SetActive(true);
            cplus_platform.SetActive(true);
        }
        else
        {
            dashboard.SetActive(false);
            cplus_platform.SetActive(false);
        }

        if (PlayerPrefs.GetString("java_ui") == "active")
        {
            dashboard_2.SetActive(true);
            java_platform.SetActive(true);
        }
        else
        {
            dashboard_2.SetActive(false);
            java_platform.SetActive(false);
        }

        if (PlayerPrefs.GetString("php_ui") == "active")
        {
            dashboard_3.SetActive(true);
            php_platform.SetActive(true);
        }
        else
        {
            dashboard_3.SetActive(false);
            php_platform.SetActive(false);
        }

    }
}
