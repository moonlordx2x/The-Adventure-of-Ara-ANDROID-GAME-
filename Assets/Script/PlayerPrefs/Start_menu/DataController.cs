using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

    public int plus_dmg = 5;
    public int plus_hp = 50;

    int storedmg1;
    int storehp2;

    void Start () {
        storedmg1 = PlayerPrefs.GetInt("Player_dmg");
        storehp2 = PlayerPrefs.GetInt("Player_hp");

        Debug.Log(storehp2);
        Debug.Log(storedmg1);
    }
	
	public void add_dmg()
    {
        plus_dmg = plus_dmg + storedmg1;
        PlayerPrefs.SetInt("Player_dmg", plus_dmg);
        PlayerPrefs.Save();
        Debug.Log(plus_dmg);
    }


    public void add_hp()
    {
        plus_hp = plus_hp + storehp2;
        PlayerPrefs.SetInt("Player_hp", plus_hp);
        PlayerPrefs.Save();
        Debug.Log(plus_hp);
    }

    public void equip_default()
    {
        Debug.Log(PlayerPrefs.GetInt("Player_id"));
        PlayerPrefs.SetInt("Player_id", 1);
    }

    public void equip_cplus()
    {
        Debug.Log(PlayerPrefs.GetInt("Player_id"));
        PlayerPrefs.SetInt("Player_id", 2);
    }

    public void equip_java()
    {
        Debug.Log(PlayerPrefs.GetInt("Player_id"));
        PlayerPrefs.SetInt("Player_id", 3);
    }

    public void equip_php()
    {
        Debug.Log(PlayerPrefs.GetInt("Player_id"));
        PlayerPrefs.SetInt("Player_id", 4);
    }
}
