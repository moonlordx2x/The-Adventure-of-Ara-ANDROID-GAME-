using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stringer_cooldown : MonoBehaviour {

    public Image stringer_image;

    public bool cooldown = false;

    Cooldown_and_Skill_Checker cooldown_skill;

    public float total_cooldown_time;
    float time = 0.5f;

	void Start () {
        cooldown_skill = GameObject.Find("Skill_cooldown_manager").GetComponent<Cooldown_and_Skill_Checker>();
    }
	
	
	void Update () {

        if (cooldown_skill.stringer_cooldown == true) {
            stringer_image.fillAmount -= 1 / total_cooldown_time * Time.deltaTime;

            if (stringer_image.fillAmount <=0)
            {
                stringer_image.fillAmount = 1;
                cooldown_skill.stringer_cooldown = false;
            }
        }
	}
}
