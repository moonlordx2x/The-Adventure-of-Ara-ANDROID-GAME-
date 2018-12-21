using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	public void reset()
    {
        PlayerPrefs.SetInt("Player_id", 1);
        PlayerPrefs.SetInt("Player_hp", 200);
        PlayerPrefs.SetInt("Player_dmg", 10);
        PlayerPrefs.SetInt("Pl_coin", 0);

        PlayerPrefs.SetString("cplus", "active");
        PlayerPrefs.SetString("java", "deactive");
        PlayerPrefs.SetString("php", "deactive");

        PlayerPrefs.SetString("cplus_1", "active");
        PlayerPrefs.SetString("cplus_2", "deactive");
        PlayerPrefs.SetString("cplus_3", "deactive");

        PlayerPrefs.Save();
    }
}
