using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_manage{
	
	void Start () {
        PlayerPrefs.SetInt("cplus_1",1);
        PlayerPrefs.SetInt("cplus_2", 0);
        PlayerPrefs.SetInt("cplus_3", 0);
        PlayerPrefs.Save();
    }
}
