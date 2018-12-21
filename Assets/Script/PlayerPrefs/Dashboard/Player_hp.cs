using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_hp : MonoBehaviour {
    // public int health = 100;

    public static float dmg;
    public float hp_bar;
    public int hp_container;
    public bool skill_triggered = false;
    public float image_amount;

    public Image image;
    int hp;



    void Start()
    {
        Time.timeScale = 1f;
        hp = PlayerPrefs.GetInt("Player_hp");
        image = GetComponent<Image>();
        dmg = hp;
    }

    void Update()
    {

    }
}
