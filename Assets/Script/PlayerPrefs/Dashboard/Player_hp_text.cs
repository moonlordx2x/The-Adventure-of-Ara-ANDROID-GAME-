using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_hp_text : MonoBehaviour {

    public Text text_hp;
    private int health_hp;


    void Start()
    {
        health_hp = PlayerPrefs.GetInt("Player_hp");
        text_hp = GetComponent<Text>();
        text_hp.text = "HP : " + health_hp;

    }

    void Update()
    {
        text_hp.text = "HP : " + health_hp;
    }
}
