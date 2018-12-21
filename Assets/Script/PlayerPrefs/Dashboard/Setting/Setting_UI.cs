using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_UI : MonoBehaviour {

    public GameObject cplus_background;
    public GameObject java_background;
    public GameObject php_background;

 

    void Start () {
        cplus_background.SetActive(false);
        java_background.SetActive(false);
        php_background.SetActive(false);

    }


    public void cplus_ui()
    {
        cplus_background.SetActive(true);
        java_background.SetActive(false);
        php_background.SetActive(false);
    }

    public void java_ui()
    {
        cplus_background.SetActive(false);
        java_background.SetActive(true);
        php_background.SetActive(false);

    }

    public void php_ui()
    {
        cplus_background.SetActive(false);
        java_background.SetActive(false);
        php_background.SetActive(true);
    }

}
