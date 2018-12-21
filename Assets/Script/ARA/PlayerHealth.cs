using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
   // public int health = 100;
    
    public static float dmg;
    public float hp_bar;
    public int hp_container;
    public bool skill_triggered = false;
    public float image_amount;

    public Image image;
    int hp;

    PlayerHealth_text player_text_hp;

    public GameObject game_over_menu;

    void Start()
    {
        Time.timeScale = 1f;
        game_over_menu.SetActive(false);
        hp = PlayerPrefs.GetInt("Player_hp");
        image = GetComponent<Image>();
        dmg = hp;

        player_text_hp = GameObject.Find("Health Value").GetComponent<PlayerHealth_text>();
    }

    void Update()
    {
        image_amount = image.fillAmount;

        if (skill_triggered == true) {
            image.fillAmount = (dmg / hp) + hp_bar;

        }
        else
        {
            image.fillAmount = (dmg / hp);
        }
            
        if (image.fillAmount <= 0){ 
           game_over();
        }
    }


    void game_over()
    {
        game_over_menu.SetActive(true);
        Time.timeScale = 0f;
    }

}
