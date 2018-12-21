using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour {

    public GameObject binary_rain;
    public GameObject eyeplus;
    public GameObject fire_switch;
    public GameObject stringer;

    public bool binary_rain_triggered = false;
    public bool eyeplus_triggered = false;
    public bool fire_switch_triggered = false;
    public bool stringer_triggered = false;


    Button binary_rain_btn;
    Button eyeplus_btn;
    Button fire_switch_btn;
    Button stringer_btn;

    float timer_binary = 2.5f;
    float timer_eye = 3.6f;
    float timer_fire = 1.5f;
    float timer_string = 3f;

    void Start () {
        binary_rain.SetActive(false);
        eyeplus.SetActive(false);
        fire_switch.SetActive(false);
        stringer.SetActive(false);

        binary_rain_btn = GameObject.Find("Binary_rain").GetComponent<Button>();
        eyeplus_btn = GameObject.Find("Eye++").GetComponent<Button>();
        fire_switch_btn = GameObject.Find("Fire_switch").GetComponent<Button>();
        stringer_btn = GameObject.Find("Stringer").GetComponent<Button>();


        binary_rain_btn.interactable = true;
        eyeplus_btn.interactable = true;
        fire_switch_btn.interactable = true;
        stringer_btn.interactable = true;
    }

	void Update () {

        if (binary_rain_triggered == true)
        {
            binary_rain.SetActive(true);
            timer_binary -= Time.deltaTime;

            eyeplus_btn.interactable = false;
            fire_switch_btn.interactable = false;
            stringer_btn.interactable = false;

            if (timer_binary <= 0)
            {
                binary_rain_triggered = false;
                timer_binary = 2.5f;

                eyeplus_btn.interactable = true;
                fire_switch_btn.interactable = true;
                stringer_btn.interactable = true;

            }
        }

        else if (eyeplus_triggered == true)
        {
            eyeplus.SetActive(true);
            timer_eye -= Time.deltaTime;

            binary_rain_btn.interactable = false;
            fire_switch_btn.interactable = false;
            stringer_btn.interactable = false;

            if (timer_eye <= 0)
            {
                eyeplus_triggered = false;
                timer_eye = 3.6f;

                binary_rain_btn.interactable = true;
                fire_switch_btn.interactable = true;
                stringer_btn.interactable = true;
            }
        }


        else if (fire_switch_triggered == true)
        {
            fire_switch.SetActive(true);
            timer_fire -= Time.deltaTime;

            binary_rain_btn.interactable = false;
            eyeplus_btn.interactable = false;
            stringer_btn.interactable = false;

            if (timer_fire <= 0)
            {
                fire_switch_triggered = false;
                timer_fire = 1.5f;

                binary_rain_btn.interactable = true;
                eyeplus_btn.interactable = true;
                stringer_btn.interactable = true;

            }
        }

        else if (stringer_triggered == true)
        {
            stringer.SetActive(true);
            timer_string -= Time.deltaTime;

            binary_rain_btn.interactable = false;
            eyeplus_btn.interactable = false;
            fire_switch_btn.interactable = false;

            if (timer_string <= 0)
            {
                stringer_triggered = false;
                timer_string = 3f;

                binary_rain_btn.interactable = true;
                eyeplus_btn.interactable = true;
                fire_switch_btn.interactable = true;

            }
        }

        else
        {
            binary_rain.SetActive(false);
            eyeplus.SetActive(false);
            fire_switch.SetActive(false);
            stringer.SetActive(false);
        }
	}
}
