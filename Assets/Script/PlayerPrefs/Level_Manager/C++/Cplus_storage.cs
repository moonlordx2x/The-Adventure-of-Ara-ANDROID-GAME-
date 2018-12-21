using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cplus_storage : MonoBehaviour {

    public string[] world;
    GameObject map;

    void Start()
    {
        if (PlayerPrefs.GetString("cplus_1") == "" && PlayerPrefs.GetString("cplus_2") == "" && PlayerPrefs.GetString("cplus_3") == "")
        {
            main_map();
        }

        Debug.Log(PlayerPrefs.GetString("cplus_1"));
        Debug.Log(PlayerPrefs.GetString("cplus_2"));
        Debug.Log(PlayerPrefs.GetString("cplus_3"));

        for (int i = 0; i < world.Length; i++)
        {
            if (PlayerPrefs.GetString(world[i]) == "deactive")
            {
                map = GameObject.Find(world[i]);
                map.SetActive(false);
            }
        }
    }

    void main_map()
    {
        PlayerPrefs.SetString("cplus_1", "active");
        PlayerPrefs.SetString("cplus_2", "deactive");
        PlayerPrefs.SetString("cplus_3", "deactive");
    }
}
