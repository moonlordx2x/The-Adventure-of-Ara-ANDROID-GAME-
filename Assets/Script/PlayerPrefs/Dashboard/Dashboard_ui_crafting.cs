using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashboard_ui_crafting : MonoBehaviour {

    public GameObject cplus_craft;
    public GameObject cplus_craft_2340;
    public GameObject java_craft;
    public GameObject java_craft_2340;

    public GameObject php_craft;
    public GameObject php_craft_2340;


    void Start () {
        cplus_craft.SetActive(false);
        cplus_craft_2340.SetActive(false);

        java_craft.SetActive(false);
        java_craft_2340.SetActive(false);

        php_craft.SetActive(false);
        php_craft_2340.SetActive(false);
    }
	
	
	public void cplus_crafting()
    {
        if (Screen.width >=2000)
        {
            cplus_craft.SetActive(false);
            cplus_craft_2340.SetActive(true);
        }
        else
        {
            cplus_craft.SetActive(true);
            cplus_craft_2340.SetActive(false);
        }

       
    }

    public void java_crafting()
    {

        if (Screen.width >= 2000)
        {
            java_craft.SetActive(false);
            java_craft_2340.SetActive(true);
        }
        else
        {
            java_craft.SetActive(true);
            java_craft_2340.SetActive(false);
        }

        
    }

    public void php_crafting()
    {
        if (Screen.width >= 2000)
        {
            php_craft.SetActive(false);
            php_craft_2340.SetActive(true);
        }
        else
        {
            php_craft.SetActive(true);
            php_craft_2340.SetActive(false);
        }
    }

    public void crafting_close()
    {
        cplus_craft.SetActive(false);
        cplus_craft_2340.SetActive(false);
        java_craft.SetActive(false);
        java_craft_2340.SetActive(false);
        php_craft.SetActive(false);
        php_craft_2340.SetActive(false);
    }
}
