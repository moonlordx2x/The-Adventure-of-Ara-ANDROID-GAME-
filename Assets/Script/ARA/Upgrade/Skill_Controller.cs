using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Controller : MonoBehaviour {

    public GameObject skill_binary;
    public GameObject skill_binary_locked;

    public GameObject skill_eyeplus;
    public GameObject skill_eyeplus_locked;

    public GameObject skill_fire_switch;
    public GameObject skill_fire_switch_locked;

    public GameObject skill_stringer;
    public GameObject skill_stringer_locked;

    void Update () {
        skill_binary_locked.SetActive(false);
        /*
        if (PlayerPrefs.GetString("crafting_reward_binary") == "Incompleted")
        {
            skill_binary.SetActive(false);
            skill_binary_locked.SetActive(true);
        }
        else
        {
            skill_binary.SetActive(true);
            skill_binary_locked.SetActive(false);
        }
        */


        if (PlayerPrefs.GetString("crafting_reward_cplus") == "Incompleted")
        {
            skill_eyeplus.SetActive(true);
            skill_eyeplus_locked.SetActive(true);
        }
        else
        {
            skill_eyeplus.SetActive(true);
            skill_eyeplus_locked.SetActive(false);
        }

        if (PlayerPrefs.GetString("crafting_reward_java") == "Incompleted")
        {
            skill_fire_switch.SetActive(true);
            skill_fire_switch_locked.SetActive(true);
        }
        else
        {
            skill_fire_switch.SetActive(true);
            skill_fire_switch_locked.SetActive(false);
        }

        if (PlayerPrefs.GetString("crafting_reward_php") == "Incompleted")
        {
            skill_stringer.SetActive(true);
            skill_stringer_locked.SetActive(true);
        }
        else
        {
            skill_stringer.SetActive(true);
            skill_stringer_locked.SetActive(false);
        }
    }
}
