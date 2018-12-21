using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checker_cplus : MonoBehaviour {

    public Text map_1;
    public Text map_2;
    public Text map_3;

    void Start()
    {
        map_1.text = PlayerPrefs.GetString("cplus_1");
        map_2.text = PlayerPrefs.GetString("cplus_2");
        map_3.text = PlayerPrefs.GetString("cplus_3");
    }

    void Update()
    {
        Debug.Log(Screen.width);    
    }

}
