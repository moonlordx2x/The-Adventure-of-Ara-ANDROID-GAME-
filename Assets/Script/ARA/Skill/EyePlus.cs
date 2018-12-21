using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyePlus : MonoBehaviour {

    public bool heal_plus = false;

    float health;
    float image_amount_percentage;
    int health_eye_plus_heal = 0;
    public bool health_eye_plus_bool = false;

    PlayerHealth_text health_value;
    PlayerHealth health_bar;

    void Start()
    {
        health_value = GameObject.Find("Health Value").GetComponent<PlayerHealth_text>();
        health_bar = GameObject.Find("Image_bar").GetComponent<PlayerHealth>();
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            //Debug.Log(health_bar.image_amount);

            if (health_bar.image_amount >= 1) { image_amount_percentage = 0f;  Debug.Log("0 percent"); }
            else if (health_bar.image_amount >= 0.99) { image_amount_percentage = 0.01f; Debug.Log("1 percent"); }
            else if (health_bar.image_amount >= 0.98) { image_amount_percentage = 0.02f; Debug.Log("2 percent"); }
            else if (health_bar.image_amount >= 0.97) { image_amount_percentage = 0.03f; Debug.Log("3 percent"); }
            else if (health_bar.image_amount >= 0.96) { image_amount_percentage = 0.04f; Debug.Log("4 percent"); }
            else if (health_bar.image_amount >= 0.95) { image_amount_percentage = 0.05f; Debug.Log("5 percent"); }
            else if (health_bar.image_amount >= 0.94) { image_amount_percentage = 0.06f; Debug.Log("6 percent"); }
            else if (health_bar.image_amount >= 0.93) { image_amount_percentage = 0.07f; Debug.Log("7 percent"); }
            else if (health_bar.image_amount >= 0.92) { image_amount_percentage = 0.08f; Debug.Log("8 percent"); }
            else if (health_bar.image_amount >= 0.91) { image_amount_percentage = 0.09f; Debug.Log("9 percent"); }
            else if (health_bar.image_amount >= 0.90) { image_amount_percentage = 0.10f; Debug.Log("10 percent"); }
            else if (health_bar.image_amount >= 0.89) { image_amount_percentage = 0.11f; Debug.Log("11 percent"); }
            else if (health_bar.image_amount >= 0.88) { image_amount_percentage = 0.12f; Debug.Log("12 percent"); }
            else if (health_bar.image_amount >= 0.87) { image_amount_percentage = 0.13f; Debug.Log("13 percent"); }
            else if (health_bar.image_amount >= 0.85) { image_amount_percentage = 0.14f; Debug.Log("14 percent"); }
            else { image_amount_percentage = 0.15f; Debug.Log("15 percent"); }


            health = PlayerPrefs.GetInt("Player_hp") * image_amount_percentage;
            health_eye_plus_heal = Mathf.RoundToInt((int)health);
            health_eye_plus_bool = true;

            //Player TEXT
            health_value.hp_container += health_eye_plus_heal;


            //Player HEALTHBAR
            health_bar.hp_container += health_eye_plus_heal;
            health_bar.hp_bar += image_amount_percentage;
            health_bar.skill_triggered = true;

            Debug.Log(health_bar.image_amount);
            Debug.Log(health);
            Debug.Log(health_eye_plus_heal);
            Debug.Log(image_amount_percentage);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            health_eye_plus_bool = true;
            health_bar.skill_triggered = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            //health = 0;
            health_eye_plus_bool = false;
            health_bar.skill_triggered = true;
        }
    }
}
