using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth_text : MonoBehaviour
{
    public static int hp_dmg;
    public int hp_container;
    public int player_health;

    public Text text_hp;
    private int health_hp;
    int hp_display;

    EyePlus eyeplus;

    void Start()
    {
        eyeplus = GameObject.Find("Head").GetComponent<EyePlus>();
        hp_dmg = 0;
        health_hp = PlayerPrefs.GetInt("Player_hp");
        text_hp = GetComponent<Text>();
        text_hp.text = health_hp.ToString();
        hp_display = health_hp;
    }

    void Update() {

        hp_display = (health_hp - hp_dmg) + hp_container;

        if (hp_display <= 0)
        {
            text_hp.text = "0";
        }


        text_hp.text = hp_display.ToString();
        player_health = hp_display;
        }
    }
