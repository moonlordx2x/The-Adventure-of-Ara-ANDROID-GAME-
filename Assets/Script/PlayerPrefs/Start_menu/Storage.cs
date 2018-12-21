using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour {

    /* --- ARA Personal Stats Default ---- */

    private int id;
    private int hp;
    private int dmg;
    private int coin;
    private int skill_1;
    private float skill_2;
    private int skill_3;
    private int skill_4;

    /* --- MAP ---- */

    private string cplus;
    private string cplus_1;
    private string cplus_2;
    private string cplus_3;

    private string java;
    private string java_1;
    private string java_2;
    private string java_3;

    private string php;
    private string php_1;
    private string php_2;
    private string php_3;

    private string tutorial;
    private string tutorial_2;
    private string tutorial_3;
    private string tutorial_4;
    private string ransomware;

    /* --- Crafting and Quest ---- */

    private string craft_reward_1;
    private string craft_reward_2;
    private string craft_reward_3;
    private string craft_reward_4;

    private string quest_cplus_1;
    private string quest_cplus_2;
    private string quest_cplus_3;

    private string quest_java_1;
    private string quest_java_2;
    private string quest_java_3;

    private string quest_php_1;
    private string quest_php_2;
    private string quest_php_3;

    private string ransomware_quest;
    private string tutorial_quest;

    /* DASHBOARD UI */

    private string cplus_ui;
    private string java_ui;
    private string php_ui;


    void Start () {
        if(PlayerPrefs.GetInt("Player_id") == 0 && PlayerPrefs.GetInt("Player_hp") == 0 && PlayerPrefs.GetInt("Player_dmg") == 0)
        {
            Default();
        }
        else
        {
            //Default();
            Load_current_data();
        }
    }

    void Default()
    {
        /* --- ARA Personal Stats Default ---- */

        PlayerPrefs.SetInt("Player_id", 1);
        PlayerPrefs.SetInt("Player_hp", 200);
        PlayerPrefs.SetInt("Player_dmg", 10);
        PlayerPrefs.SetInt("Pl_coin", 50000000);
        PlayerPrefs.SetInt("Binary_rain", 0);
        PlayerPrefs.SetFloat("Eye_plus", 60);
        PlayerPrefs.SetInt("Fire_switch", 25);
        PlayerPrefs.SetInt("Stringer", 5);

        /* --- MAP ---- */

        PlayerPrefs.SetString("cplus", "Active");
        PlayerPrefs.SetString("java", "Active");
        PlayerPrefs.SetString("php", "Active");

        PlayerPrefs.SetString("cplus_1", "Active");
        PlayerPrefs.SetString("cplus_2", "Active");
        PlayerPrefs.SetString("cplus_3", "Active");
        PlayerPrefs.SetString("java_1", "Active");
        PlayerPrefs.SetString("java_2", "Active");
        PlayerPrefs.SetString("java_3", "Active");
        PlayerPrefs.SetString("php_1", "Active");
        PlayerPrefs.SetString("php_2", "Active");
        PlayerPrefs.SetString("php_3", "Active");

        PlayerPrefs.SetString("tutorial", "Active");
        PlayerPrefs.SetString("tutorial_2", "Active");
        PlayerPrefs.SetString("tutorial_3", "Deactive");
        PlayerPrefs.SetString("tutorial_4", "Deactive");

        PlayerPrefs.SetString("ransomware", "Active");

        /* --- Crafting and Quest ---- */

        PlayerPrefs.SetString("crafting_reward_binary", "Completed");
        PlayerPrefs.SetString("crafting_reward_cplus", "Completed");
        PlayerPrefs.SetString("crafting_reward_java", "Completed");
        PlayerPrefs.SetString("crafting_reward_php", "Completed");

        PlayerPrefs.SetString("quest_cplus_1", "Completed");
        PlayerPrefs.SetString("quest_cplus_2", "Completed");
        PlayerPrefs.SetString("quest_cplus_3", "Completed");

        PlayerPrefs.SetString("quest_java_1", "Completed");
        PlayerPrefs.SetString("quest_java_2", "Completed");
        PlayerPrefs.SetString("quest_java_3", "Completed");

        PlayerPrefs.SetString("quest_php_1", "Completed");
        PlayerPrefs.SetString("quest_php_2", "Completed");
        PlayerPrefs.SetString("quest_php_3", "Completed");

        PlayerPrefs.SetString("ransomware_quest", "Completed");

        /* Inventory*/

        /* DASHBOARD UI */

        PlayerPrefs.SetString("cplus_ui", "active");
        PlayerPrefs.SetString("java_ui", "deactive");
        PlayerPrefs.SetString("php_ui", "deactive");
    }

    void Emptys()
    {
        /* --- ARA Personal Stats if reset ---- */

        PlayerPrefs.SetInt("Player_id", 0);
        PlayerPrefs.SetInt("Player_hp", 0);
        PlayerPrefs.SetInt("Player_dmg", 0);
        PlayerPrefs.SetInt("Pl_coin", 0);
        PlayerPrefs.SetInt("Pl_coin", 0);
        PlayerPrefs.SetInt("Binary_rain", 0);
        PlayerPrefs.SetFloat("Eye_plus", 0);
        PlayerPrefs.SetInt("Fire_switch", 0);
        PlayerPrefs.SetInt("Stringer", 0);

    }

    void Load_current_data()
    {
        /* --- ARA Personal Stats if reset ---- */

        id = PlayerPrefs.GetInt("Player_id");
        hp = PlayerPrefs.GetInt("Player_hp");
        dmg = PlayerPrefs.GetInt("Player_dmg");
        coin = PlayerPrefs.GetInt("Pl_coin");

        skill_1 = PlayerPrefs.GetInt("Binary_rain");
        skill_2 = PlayerPrefs.GetFloat("Eye_plus");
        skill_3 = PlayerPrefs.GetInt("Fire_switch");
        skill_4 = PlayerPrefs.GetInt("Stringer");

        PlayerPrefs.SetInt("Player_id", id);
        PlayerPrefs.SetInt("Player_hp", hp);
        PlayerPrefs.SetInt("Player_dmg", dmg);
        PlayerPrefs.SetInt("Pl_coin", coin);

        PlayerPrefs.SetInt("Binary_rain", skill_1);
        PlayerPrefs.SetFloat("Eye_plus", skill_2);
        PlayerPrefs.SetInt("Fire_switch", skill_3);
        PlayerPrefs.SetInt("Stringer", skill_4);


        /* --- MAP if reset ---- */

        cplus = PlayerPrefs.GetString("cplus");
        cplus_1 = PlayerPrefs.GetString("cplus_1");
        cplus_2 = PlayerPrefs.GetString("cplus_2");
        cplus_3 = PlayerPrefs.GetString("cplus_3");

        java = PlayerPrefs.GetString("java");
        java_1 = PlayerPrefs.GetString("java_1");
        java_2 = PlayerPrefs.GetString("java_2");
        java_3 = PlayerPrefs.GetString("java_3");

        php = PlayerPrefs.GetString("php");
        php_1 = PlayerPrefs.GetString("php_1");
        php_2 = PlayerPrefs.GetString("php_2");
        php_3 = PlayerPrefs.GetString("php_3");

        tutorial = PlayerPrefs.GetString("tutorial");
        ransomware = PlayerPrefs.GetString("ransomware");

        PlayerPrefs.SetString("cplus", cplus);
        PlayerPrefs.SetString("java", java);
        PlayerPrefs.SetString("php", php);

        PlayerPrefs.SetString("cplus_1", cplus_1);
        PlayerPrefs.SetString("cplus_2", cplus_2);
        PlayerPrefs.SetString("cplus_3", cplus_3);
        PlayerPrefs.SetString("java_1", java_1);
        PlayerPrefs.SetString("java_2", java_2);
        PlayerPrefs.SetString("java_3", java_3);
        PlayerPrefs.SetString("php_1", php_1);
        PlayerPrefs.SetString("php_2", php_2);
        PlayerPrefs.SetString("php_3", php_3);

        PlayerPrefs.SetString("tutorial", tutorial);
        PlayerPrefs.SetString("ransomware", ransomware);

        /* --- Crafting and Quest ---- */

        craft_reward_1 = PlayerPrefs.GetString("crafting_reward_binary");
        craft_reward_2 = PlayerPrefs.GetString("crafting_reward_cplus");
        craft_reward_3 = PlayerPrefs.GetString("crafting_reward_java");
        craft_reward_4 = PlayerPrefs.GetString("crafting_reward_php");

        quest_cplus_1 = PlayerPrefs.GetString("quest_cplus_1");
        quest_cplus_2 = PlayerPrefs.GetString("quest_cplus_2");
        quest_cplus_3 = PlayerPrefs.GetString("quest_cplus_3");

        quest_java_1 = PlayerPrefs.GetString("quest_java_1");
        quest_java_2 = PlayerPrefs.GetString("quest_java_2");
        quest_java_3 = PlayerPrefs.GetString("quest_java_3");

        quest_php_1 = PlayerPrefs.GetString("quest_php_1");
        quest_php_2 = PlayerPrefs.GetString("quest_php_2");
        quest_php_3 = PlayerPrefs.GetString("quest_php_3");

        ransomware_quest = PlayerPrefs.GetString("ransomware_quest");

        PlayerPrefs.SetString("crafting_reward_binary", craft_reward_1);
        PlayerPrefs.SetString("crafting_reward_cplus", craft_reward_2);
        PlayerPrefs.SetString("crafting_reward_java", craft_reward_3);
        PlayerPrefs.SetString("crafting_reward_php", craft_reward_4);

        PlayerPrefs.SetString("quest_cplus_1", quest_cplus_1);
        PlayerPrefs.SetString("quest_cplus_2", quest_cplus_2);
        PlayerPrefs.SetString("quest_cplus_3", quest_cplus_3);

        PlayerPrefs.SetString("quest_java_1", quest_java_1);
        PlayerPrefs.SetString("quest_java_2", quest_java_2);
        PlayerPrefs.SetString("quest_java_3", quest_java_3);

        PlayerPrefs.SetString("quest_php_1", quest_php_1);
        PlayerPrefs.SetString("quest_php_2", quest_php_2);
        PlayerPrefs.SetString("quest_php_3", quest_php_3);

        PlayerPrefs.SetString("ransomware_quest", ransomware_quest);

        /* DASHBOARD UI */

        cplus_ui = PlayerPrefs.GetString("cplus_ui");
        java_ui = PlayerPrefs.GetString("java_ui");
        php_ui = PlayerPrefs.GetString("php_ui");

        PlayerPrefs.SetString("cplus_ui", cplus_ui);
        PlayerPrefs.SetString("java_ui", java_ui);
        PlayerPrefs.SetString("php_ui", php_ui);

    }
}
