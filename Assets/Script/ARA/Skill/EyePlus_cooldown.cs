using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyePlus_cooldown : MonoBehaviour {
    public Image eye_plus_image;

    public bool cooldown = false;

    Cooldown_and_Skill_Checker cooldown_skill;

    public float total_cooldown_time;
    float time = 0.5f;

    void Start()
    {
        cooldown_skill = GameObject.Find("Skill_cooldown_manager").GetComponent<Cooldown_and_Skill_Checker>();
        total_cooldown_time = PlayerPrefs.GetFloat("Eye_plus");
    }


    void Update()
    {

        if (cooldown_skill.eyeplus_cooldown == true)
        {
            eye_plus_image.fillAmount -= 1 / total_cooldown_time * Time.deltaTime;

            if (eye_plus_image.fillAmount <= 0)
            {
                eye_plus_image.fillAmount = 1;
                cooldown_skill.eyeplus_cooldown = false;
            }
        }
    }
}
