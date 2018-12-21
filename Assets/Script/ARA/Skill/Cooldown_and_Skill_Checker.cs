using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown_and_Skill_Checker : MonoBehaviour {

    public GameObject BinaryRain;
    public GameObject EyePlus;
    public GameObject FireSwitch;
    public GameObject Stringer;

    public bool binaryrain_cooldown;
    public bool eyeplus_cooldown;
    public bool fireswitch_cooldown;
    public bool stringer_cooldown;

    public GameObject skill_binary_locked;
    public GameObject skill_eyeplus_locked;
    public GameObject skill_fire_switch_locked;
    public GameObject skill_stringer_locked;

    void Start () {

        BinaryRain.SetActive(false);
        EyePlus.SetActive(false);
        FireSwitch.SetActive(false);
        Stringer.SetActive(false);
        skill_binary_locked.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (PlayerPrefs.GetString("crafting_reward_binary") == "Incompleted") { skill_binary_locked.SetActive(true);}
        else { skill_binary_locked.SetActive(false);}
        
        if (PlayerPrefs.GetString("crafting_reward_cplus") == "Incompleted") { skill_eyeplus_locked.SetActive(true);}
        else { skill_eyeplus_locked.SetActive(false); }

        if (PlayerPrefs.GetString("crafting_reward_java") == "Incompleted") { skill_fire_switch_locked.SetActive(true);}
        else { skill_fire_switch_locked.SetActive(false);}

        if (PlayerPrefs.GetString("crafting_reward_php") == "Incompleted") { skill_stringer_locked.SetActive(true); }
        else { skill_stringer_locked.SetActive(false); }

        if (binaryrain_cooldown == true) { BinaryRain.SetActive(true); }
        else { BinaryRain.SetActive(false); }

        if (eyeplus_cooldown == true) { EyePlus.SetActive(true); }
        else { EyePlus.SetActive(false); }

        if (fireswitch_cooldown == true) { FireSwitch.SetActive(true); }
        else { FireSwitch.SetActive(false); }

        if (stringer_cooldown == true) { Stringer.SetActive(true); }
        else { Stringer.SetActive(false); }

    }
}
