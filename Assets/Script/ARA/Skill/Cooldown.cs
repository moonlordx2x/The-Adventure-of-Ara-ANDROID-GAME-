using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour {

    public GameObject BinaryRain;
    public GameObject EyePlus;
    public GameObject FireSwitch;
    public GameObject Stringer;

    public bool binaryrain_cooldown;
    public bool eyeplus_cooldown;
    public bool fireswitch_cooldown;
    public bool stringer_cooldown;

    
    void Start()
    {
        BinaryRain.SetActive(false);
        EyePlus.SetActive(false);
        FireSwitch.SetActive(false);
        Stringer.SetActive(false);
    }
    

    void Update()
    {
        if (binaryrain_cooldown == true) { BinaryRain.SetActive(true); }
        else                             { BinaryRain.SetActive(false); }

        if (eyeplus_cooldown == true)    { EyePlus.SetActive(true); }
        else                             { EyePlus.SetActive(false); }

        if (fireswitch_cooldown == true) { FireSwitch.SetActive(true); }
        else                             { FireSwitch.SetActive(false); }

        if (stringer_cooldown == true)   { Stringer.SetActive(true); }
        else                             { Stringer.SetActive(false); }
        

    }

}
