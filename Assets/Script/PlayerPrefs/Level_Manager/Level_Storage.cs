using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Storage : MonoBehaviour {

    public string[] world;
    GameObject map;

    void Start() {

        if(PlayerPrefs.GetString("cplus") == "" && PlayerPrefs.GetString("java") == "" && PlayerPrefs.GetString("php") == "")
        {
            main_map();
        }

        Debug.Log(PlayerPrefs.GetString("cplus"));
        Debug.Log(PlayerPrefs.GetString("java"));
        Debug.Log(PlayerPrefs.GetString("php"));

        for (int i =0;i<world.Length;i++)
        {
            if(PlayerPrefs.GetString(world[i]) == "deactive")
            {
                map = GameObject.Find(world[i]);
                map.SetActive(false);
            }
        }
    }

    void cplus()
    {

    }

    void java()
    {

    }

    void php()
    {

    }

    void main_map()
    {
        PlayerPrefs.SetString("cplus", "active");
        PlayerPrefs.SetString("java", "deactive");
        PlayerPrefs.SetString("php", "deactive");
    }
	
}
