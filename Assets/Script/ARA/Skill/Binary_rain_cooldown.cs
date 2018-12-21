using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Binary_rain_cooldown : MonoBehaviour {

    public Image binary_image;

    Cooldown_and_Skill_Checker cooldown_skill;

    public float total_cooldown_time;
    float time = 0.5f;

    void Start()
    {
        cooldown_skill = GameObject.Find("Skill_cooldown_manager").GetComponent<Cooldown_and_Skill_Checker>();
    }


    void Update()
    {

        if (cooldown_skill.binaryrain_cooldown == true)
        {
            binary_image.fillAmount -= 1 / total_cooldown_time * Time.deltaTime;

            if (binary_image.fillAmount <= 0)
            {
                binary_image.fillAmount = 1;
                cooldown_skill.binaryrain_cooldown = false;
            }
        }
    }
}
