using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_audio : MonoBehaviour {

    public GameObject btn_sound;

    float timer_btn = 1.7f;
    bool btn_triggerd;

    void Start () {
        btn_sound.SetActive(false);

    }
	
	
	void Update () {

        if (btn_triggerd == true)
        {
            btn_sound.SetActive(true);
            timer_btn -= Time.deltaTime;

            if (timer_btn <= 0)
            {
                timer_btn = 1.7f;
                btn_triggerd = false;

            }
        }
        else
        {
            btn_sound.SetActive(false);
        }

	}

    public void btn()
    {
        btn_triggerd = true;
    }
}
