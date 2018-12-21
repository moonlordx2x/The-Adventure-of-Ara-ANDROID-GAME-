using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_attack : MonoBehaviour {

    public Animator enemyanimation;
    public float player_damage_bar;
    public int player_damage_text;
    public bool player_detection = false;
   // public GameObject game_over_menu;

 
    void Start()
    {
        //game_over_menu.SetActive(false);
    }

    void Update()
    {

        if (player_detection == true)
        {
            enemyanimation.SetTrigger("Attack");
        }
        else
        {
            enemyanimation.SetTrigger("Default");
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerHealth.dmg -= player_damage_bar;
            PlayerHealth_text.hp_dmg += player_damage_text;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player_detection = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player_detection = false;
        }
    }

    void game_over()
    {
        //game_over_menu.SetActive(true);
        Time.timeScale = 0f;
    }
}
