using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checker_java : MonoBehaviour {

    public Text map_1;
    public Text map_2;
    public Text map_3;

    void Start()
    {
        map_1.text = PlayerPrefs.GetString("java_1");
        map_2.text = PlayerPrefs.GetString("java_2");
        map_3.text = PlayerPrefs.GetString("java_3");
    }
}
