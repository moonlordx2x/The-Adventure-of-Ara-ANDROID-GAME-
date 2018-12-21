using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Controller : MonoBehaviour {


    public void active_map()
    {

        PlayerPrefs.SetString("cplus", "active");
        PlayerPrefs.SetString("java", "active");
        PlayerPrefs.SetString("php", "active");
        PlayerPrefs.SetString("cplus_1", "active");
        PlayerPrefs.SetString("cplus_2", "active");
        PlayerPrefs.SetString("cplus_3", "active");
        PlayerPrefs.Save();


        Debug.Log(PlayerPrefs.GetString("cplus"));
        Debug.Log(PlayerPrefs.GetString("java"));
        Debug.Log(PlayerPrefs.GetString("php"));

        Debug.Log(PlayerPrefs.GetString("cplus_1"));
        Debug.Log(PlayerPrefs.GetString("cplus_2"));
        Debug.Log(PlayerPrefs.GetString("cplus_3"));

        Debug.Log("active");
    }
}
