using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy_health_bar : MonoBehaviour {

    public Image image;
    public float health;
	float damages;
	int player_damage;
	private string connect;
	bool triggerd = false;
    bool binary_rain = false;
    float binary_rain_skill;
    float binary_rain_skill1;

    bool fire_switch = false;
    float fire_switch_skill;
    float fire_switch_skill1;

    bool stringer = false;
    float stringer_skill;
    float stringer_skill1;

    Enemy_health healths;

    public GameObject parent;

    public GameObject blood;

    int coin;
    float position_y;

    void Start()
    {
        player_damage = PlayerPrefs.GetInt("Player_dmg");
        binary_rain_skill = PlayerPrefs.GetInt("Binary_rain");
        fire_switch_skill = PlayerPrefs.GetInt("Fire_switch");
        stringer_skill = PlayerPrefs.GetInt("Stringer");
        image = GetComponent<Image>();
        healths = GetComponentInParent<Enemy_health>();
        health = (float)healths.HP;
        position_y = 5f;

    }


    void FixedUpdate()
    {
        coin = PlayerPrefs.GetInt("Pl_coin");
        if (image.fillAmount <= 0)
        {
            Blood();
            PlayerPrefs.SetInt("Pl_coin", coin + 2);
            PlayerPrefs.Save();
        }
    }

    void Blood()
    {
        Instantiate(blood, new Vector2(transform.position.x,position_y), Quaternion.identity);
        Destroy(parent);
    }


    void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "sword") {

			triggerd = true;
            binary_rain = false;
            fire_switch = false;
            stringer = false;
            Health ();
        }
        
        if (col.gameObject.tag == "binary_rain")
        {
            triggerd = false;
            binary_rain = true;
            fire_switch = false;
            stringer = false;
            Health();
        }

        if (col.gameObject.tag == "fireswitch")
        {
            triggerd = false;
            binary_rain = false;
            fire_switch = true;
            stringer = false;
            Health();
        }

        if (col.gameObject.tag == "stringer")
        {
            triggerd = false;
            binary_rain = false;
            fire_switch = false;
            stringer = true;
            Health();
        }

        if (col.gameObject.tag == "platform")
        {
            Debug.Log("hello world");
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "stringer")
        {
            triggerd = false;
            binary_rain = false;
            fire_switch = false;
            stringer = true;
            Health();
        }
    }

    void Health()
    {
        if (triggerd == true && binary_rain == false && fire_switch == false && stringer == false)
        {
            damages = player_damage / health;
            image.fillAmount -= damages;
        }

        else if (binary_rain == true && triggerd == false && fire_switch == false && stringer == false)
        {
            binary_rain_skill1 = binary_rain_skill / health;
            image.fillAmount -= binary_rain_skill1;         
        }

        else if (fire_switch == true && triggerd == false && binary_rain == false && stringer == false)
        {
            fire_switch_skill1 = fire_switch_skill / health;
            image.fillAmount -= fire_switch_skill1;      
        }

        else if (stringer == true && triggerd == false && binary_rain == false && fire_switch == false)
        {
            stringer_skill1 = stringer_skill / health;
            image.fillAmount -= stringer_skill1;    
        }
    }
}
