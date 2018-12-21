using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_locked : MonoBehaviour {

    public GameObject cplus_button;
    public GameObject java_button;
    public GameObject php_button;

    void Start () {
		
	}

    
   void Update () {

       if (PlayerPrefs.GetString("cplus") == "Active")
       {
            cplus_button.SetActive(false);
       }
       else
       {
            cplus_button.SetActive(true);
       }

       if (PlayerPrefs.GetString("java") == "Active")
       {
            java_button.SetActive(false);
       }
       else
       {
            java_button.SetActive(true);
       }

       if (PlayerPrefs.GetString("php") == "Active")
       {
            php_button.SetActive(false);
       }
       else
       {
            php_button.SetActive(true);
       }

   }
   
}
