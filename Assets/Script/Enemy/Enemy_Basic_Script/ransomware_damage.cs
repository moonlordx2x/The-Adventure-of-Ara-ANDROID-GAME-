using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ransomware_damage : MonoBehaviour {

    public float player_damage_bar;
    public int player_damage_text;
    //public GameObject game_over_menu;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerHealth.dmg -= player_damage_bar;
            PlayerHealth_text.hp_dmg += player_damage_text;
        }
    }
}
