using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Crafting : MonoBehaviour {


    public GameObject button_1;
    public GameObject button_2;

    public GameObject craft_locked;
    public GameObject craft_unlocked;

    public GameObject upgrade_locked;
    public GameObject upgrade_unlocked;

    public GameObject success_craft;
    public GameObject return_menu;

    public GameObject tutorial_1;
    public GameObject tutorial_2;

    void Start () {

        PlayerPrefs.SetInt("Pl_coin", 75);

        button_1.SetActive(true);
        button_2.SetActive(false);

        craft_unlocked.SetActive(true);
        craft_locked.SetActive(false);

        upgrade_locked.SetActive(true);
        upgrade_unlocked.SetActive(false);

        success_craft.SetActive(false);
        return_menu.SetActive(false);

        tutorial_1.SetActive(true);
        tutorial_2.SetActive(false);

    }
	
	public void Completed()
    {
        button_1.SetActive(false);
        button_2.SetActive(true);

        craft_unlocked.SetActive(false);
        craft_locked.SetActive(true);

        upgrade_locked.SetActive(false);
        upgrade_unlocked.SetActive(true);

        success_craft.SetActive(true);
        return_menu.SetActive(true);

        tutorial_1.SetActive(false);
        tutorial_2.SetActive(true);
    }
}
