using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Craft_Button : MonoBehaviour {

    bool cplus_triggered;
    bool java_triggered;
    bool php_triggered;
    int coin;

    public Text pl_coin;

    public GameObject Cplus_notification;

    void Start()
    {
        //pl_coin = GameObject.Find("PL_COIN").GetComponent<Text>();
        
    }

    void Update () {

        if (PlayerPrefs.GetString("quest_cplus_3") == "Completed" &&
            PlayerPrefs.GetString("quest_cplus_2") == "Completed" &&
            PlayerPrefs.GetString("quest_cplus_1") == "Completed" &&
            PlayerPrefs.GetInt("Pl_coin") >= 500 && cplus_triggered == true)
        {
            PlayerPrefs.SetString("crafting_reward_cplus", "Completed");
        }

        if (PlayerPrefs.GetString("quest_java_1") == "Completed" &&
            PlayerPrefs.GetString("quest_java_2") == "Completed" &&
            PlayerPrefs.GetString("quest_java_3") == "Completed" &&
            PlayerPrefs.GetInt("Pl_coin") >= 600 && java_triggered == true)
        {
            PlayerPrefs.SetString("crafting_reward_java", "Completed");
        }

        if (PlayerPrefs.GetString("quest_php_1") == "Completed" &&
            PlayerPrefs.GetString("quest_php_2") == "Completed" &&
            PlayerPrefs.GetString("quest_php_3") == "Completed" &&
            PlayerPrefs.GetInt("Pl_coin") >= 700 && php_triggered == true)
        {
            PlayerPrefs.SetString("crafting_reward_php", "Completed");
        }

        coin = PlayerPrefs.GetInt("Pl_coin");
        pl_coin.text = coin + " COINs";
        Debug.Log(coin);
    }

    public void craft_cplus()
    {
        Cplus_notification.SetActive(true);
    }

    public void craft_cplus_close()
    {
        Cplus_notification.SetActive(false);
    }

    public void cplus_button()
    {
        cplus_triggered = true;

        if (PlayerPrefs.GetInt("Pl_coin") >= 500)
        {
            PlayerPrefs.SetInt("Pl_coin", coin - 500);
            PlayerPrefs.Save();
        }

        Cplus_notification.SetActive(false);

    }

    public void java_button()
    {
        java_triggered = true;

        if (PlayerPrefs.GetInt("Pl_coin") >= 600)
        {
            PlayerPrefs.SetInt("Pl_coin", coin - 600);
            PlayerPrefs.Save();
        }

        Cplus_notification.SetActive(false);
    }

    public void php_button()
    {
        php_triggered = true;

        if (PlayerPrefs.GetInt("Pl_coin") >= 700)
        {
            PlayerPrefs.SetInt("Pl_coin", coin - 700);
            PlayerPrefs.Save();
        }

        Cplus_notification.SetActive(false);
    }
}
