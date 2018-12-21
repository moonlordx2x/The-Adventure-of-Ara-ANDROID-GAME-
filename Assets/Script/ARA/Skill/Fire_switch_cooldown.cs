using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire_switch_cooldown : MonoBehaviour {

    public Image fireswitch_image;

    public bool cooldown = false;

    Cooldown_and_Skill_Checker cooldown_skill;

    public float total_cooldown_time;
    float time = 0.5f;

    void Start()
    {
        cooldown_skill = GameObject.Find("Skill_cooldown_manager").GetComponent<Cooldown_and_Skill_Checker>();
    }


    void Update()
    {

        if (cooldown_skill.fireswitch_cooldown == true)
        {
            fireswitch_image.fillAmount -= 1 / total_cooldown_time * Time.deltaTime;

            if (fireswitch_image.fillAmount <= 0)
            {
                fireswitch_image.fillAmount = 1;
                cooldown_skill.fireswitch_cooldown = false;
            }
        }
    }
}
