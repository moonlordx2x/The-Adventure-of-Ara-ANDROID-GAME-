using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour {

    Text HP_text;
    Text Attack_text;
    Text Binary_text;
    Text Eye_text;
    Text Fire_text;
    Text String_text;
    Text Coin_text;

    int coin;
    int current_hp;
    int attack_dmg;
    int binary_rain;
    float eyeplus;
    int fire_switch;
    int stringer;

    int health;

    public GameObject Save_locked;
    public GameObject notificaation;
    bool save_unlocked;

    void Start() {
        HP_text = GameObject.Find("HP_TEXT").GetComponent<Text>();
        Attack_text = GameObject.Find("ATTACK_TEXT").GetComponent<Text>();
        Binary_text = GameObject.Find("BINARY_TEXT").GetComponent<Text>();
        Eye_text = GameObject.Find("EYE_BINARY").GetComponent<Text>();
        Fire_text = GameObject.Find("FIRE_TEXT").GetComponent<Text>();
        String_text = GameObject.Find("STRING_TEXT").GetComponent<Text>();
        Coin_text = GameObject.Find("COIN_TEXT").GetComponent<Text>();

        coin = PlayerPrefs.GetInt("Pl_coin");

        current_hp = PlayerPrefs.GetInt("Player_hp");
        attack_dmg = PlayerPrefs.GetInt("Player_dmg");
        binary_rain = PlayerPrefs.GetInt("Binary_rain");
        eyeplus = PlayerPrefs.GetFloat("Eye_plus");
        fire_switch = PlayerPrefs.GetInt("Fire_switch");
        stringer = PlayerPrefs.GetInt("Stringer");

        save_unlocked = false;
        notificaation.SetActive(false);
    }



    void Update() {

        if (save_unlocked == true)
        {
            Save_locked.SetActive(false);
        }
        else
        {
            Save_locked.SetActive(true);
        }

        if (current_hp >= 2000)
        {
            HP_text.text = "MAX : " + current_hp;
        }
        else
        {
            HP_text.text = "HP : " + current_hp;
        }

        if (attack_dmg >=100)
        {
            Attack_text.text = "MAX : " + attack_dmg;
        }
        else
        {
            Attack_text.text = "Attack : " + attack_dmg;
        }

        if (binary_rain >=25)
        {
            Binary_text.text = "MAX : " + binary_rain;
        }
        else
        {
            Binary_text.text = "Binary Rain : " + binary_rain;
        }

        if (eyeplus <= 36f)
        {
            Eye_text.text = "MAX : " + eyeplus;
        }
        else
        {
            Eye_text.text = "Eye++ : " + eyeplus;
        }

        if (fire_switch >= 50)
        {
            Fire_text.text = "MAX : " + fire_switch;
        }
        else
        {
            Fire_text.text = "Fire Switch : " + fire_switch;
        }

        if (stringer >= 30)
        {
            String_text.text = "MAX : " + stringer;
        }
        else
        {
            String_text.text = "Stringer : " + stringer;
        }


        Coin_text.text = coin + " COINs";
    }

    public void add_Hp_button() {

        save_unlocked = true;

        if (current_hp >= 2000)
        {
            current_hp = 2000;     
        }
        else
        {
            if (coin >= 75)
            {
                current_hp += 50;
                coin -= 75;
            }
        }
    }

    public void sub_Hp_button() {
        save_unlocked = true;


        if (current_hp > PlayerPrefs.GetInt("Player_hp")) {
            current_hp -= 25;
            coin += 75;
        }
    }


    public void add_attack_button()
    {
        save_unlocked = true;

        if (attack_dmg >= 100)
        {
            attack_dmg = 100;
        }
        else
        {
            if (coin >= 75)
            {
                attack_dmg += 10;
                coin -= 75;
            }
        }

        
    }

    public void sub_attack_button()
    {
        save_unlocked = true;

        if (attack_dmg > PlayerPrefs.GetInt("Player_dmg"))
        {
            attack_dmg -= 10;
            coin += 75;
        }
    }

    public void add_binary_button()
    {
        save_unlocked = true;

        if (binary_rain >= 25)
        {
            binary_rain = 25;
        }
        else
        {
            if (coin >= 75)
            {
                binary_rain += 5;
                coin -= 75;
            }
        }
    }

    public void sub_binary_button()
    {
        save_unlocked = true;


        if (binary_rain > PlayerPrefs.GetInt("Binary_rain"))
        {
            binary_rain -= 5;
            coin += 75;
        }
    }

    public void add_eye_button()
    {
        save_unlocked = true;

        if (eyeplus <= 36)
        {
            eyeplus = 36;
        }
        else
        {
            if (coin >= 75)
            {
                eyeplus -= 2;
                coin -= 75;
            }
        }
        
    }

    public void sub_eye_button()
    {
        save_unlocked = true;

        if (eyeplus < PlayerPrefs.GetFloat("Eye_plus"))
        {
            eyeplus += 2;
            coin += 75;
        }
    }

    public void add_fire_button()
    {
        save_unlocked = true;

        if (fire_switch >= 50)
        {
            fire_switch = 50;
        }
        else
        {
            if (coin >= 75)
            {
                fire_switch += 5;
                coin -= 75;
            }
        }
    }

    public void sub_fire_button()
    {
        save_unlocked = true;


        if (fire_switch > PlayerPrefs.GetInt("Fire_switch"))
        {
            fire_switch -= 5;
            coin += 75;
        }
    }

    public void add_string_button()
    {
        save_unlocked = true;

        if (stringer >= 30)
        {
            stringer = 30;
        }

        else
        {
            if (coin >= 75)
            {
                stringer += 5;
                coin -= 150;
            }
        }
    }

    public void sub_string_button()
    {
        save_unlocked = true;


        if (stringer > PlayerPrefs.GetInt("Stringer"))
        {
            stringer -= 5;
            coin += 150;
        }
    }


    public void save_btn()
    {
        PlayerPrefs.SetInt("Player_hp", current_hp);
        PlayerPrefs.SetInt("Player_dmg", attack_dmg);
        PlayerPrefs.SetInt("Binary_rain", binary_rain);
        PlayerPrefs.SetFloat("Eye_plus", eyeplus);
        PlayerPrefs.SetInt("Fire_switch", fire_switch);
        PlayerPrefs.SetInt("Stringer", stringer);
        PlayerPrefs.SetInt("Pl_coin", coin);
        PlayerPrefs.Save();

        notificaation.SetActive(false);
        save_unlocked = false;
    }


    public void open_notication()
    {
        notificaation.SetActive(true);
    }

    public void close_notication()
    {
        notificaation.SetActive(false);
    }

    public void back_btn(){

        save_unlocked = false;
        
        current_hp = PlayerPrefs.GetInt("Player_hp");
        attack_dmg = PlayerPrefs.GetInt("Player_dmg");
        binary_rain = PlayerPrefs.GetInt("Binary_rain");
        eyeplus = PlayerPrefs.GetFloat("Eye_plus");
        fire_switch = PlayerPrefs.GetInt("Fire_switch");
        stringer = PlayerPrefs.GetInt("Stringer");
        coin = PlayerPrefs.GetInt("Pl_coin");


        PlayerPrefs.SetInt("Player_hp", current_hp);
        PlayerPrefs.SetInt("Player_dmg", attack_dmg);
        PlayerPrefs.SetInt("Binary_rain", binary_rain);
        PlayerPrefs.SetFloat("Eye_plus", eyeplus);
        PlayerPrefs.SetInt("Fire_switch", fire_switch);
        PlayerPrefs.SetInt("Stringer", stringer);
        PlayerPrefs.SetInt("Pl_coin", coin);
        PlayerPrefs.Save();

    }
    
}
