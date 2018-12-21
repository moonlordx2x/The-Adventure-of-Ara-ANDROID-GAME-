using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equit_suits : MonoBehaviour {


    public GameObject cplus_unequip;
    public GameObject java_unequip;
    public GameObject php_unequip;
    

    void Start()
    {
        cplus_unequip.SetActive(false);
        java_unequip.SetActive(false);
        php_unequip.SetActive(false);
    }

   
    void Update(){

        Debug.Log(PlayerPrefs.GetInt("Player_id"));

        if (PlayerPrefs.GetInt("Player_id") == 2)
        {
            cplus_unequip.SetActive(true);
        }
        else
        {
            cplus_unequip.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Player_id") == 3)
        {
            java_unequip.SetActive(true);
        }
        else
        {
            java_unequip.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Player_id") == 4)
        {
            php_unequip.SetActive(true);
        }
        else
        {
            php_unequip.SetActive(false);
        }
    }

    public void equip_default()
    {
        PlayerPrefs.SetInt("Player_id", 1);
        PlayerPrefs.Save();
    }

    public void equip_cplus(){
        PlayerPrefs.SetInt("Player_id", 2);
        PlayerPrefs.Save();
    }

    public void equip_java()
    {
        PlayerPrefs.SetInt("Player_id", 3);
        PlayerPrefs.Save();
    }

    public void equip_php()
    {
        PlayerPrefs.SetInt("Player_id", 4);
        PlayerPrefs.Save();
    }


}
