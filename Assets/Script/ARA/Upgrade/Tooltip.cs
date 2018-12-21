using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour {

    public GameObject Hp_tooltip;
    public GameObject attack_tooltip;
    public GameObject binary_tooltip;
    public GameObject eye_tooltip;
    public GameObject fire_tooltip;
    public GameObject stringer_tooltip;

    void Start () {

        Hp_tooltip.SetActive(false);
        attack_tooltip.SetActive(false);
        binary_tooltip.SetActive(false);
        eye_tooltip.SetActive(false);
        fire_tooltip.SetActive(false);
        stringer_tooltip.SetActive(false);

    }

    public void HP_active()
    {
        Hp_tooltip.SetActive(true);
    }

    public void HP_deactive()
    {
        Hp_tooltip.SetActive(false);
    }

    public void attack_active()
    {
        attack_tooltip.SetActive(true);
    }

    public void attack_deactive()
    {
        attack_tooltip.SetActive(false);
    }

    public void binary_active()
    {
        binary_tooltip.SetActive(true);
    }

    public void binary_deactive()
    {
        binary_tooltip.SetActive(false);
    }

    public void eye_active()
    {
        eye_tooltip.SetActive(true);
    }

    public void eye_deactive()
    {
        eye_tooltip.SetActive(false);
    }

    public void fire_active()
    {
        fire_tooltip.SetActive(true);
    }

    public void fire_deactive()
    {
        fire_tooltip.SetActive(false);
    }

    public void string_active()
    {
        stringer_tooltip.SetActive(true);
    }

    public void string_deactive()
    {
        stringer_tooltip.SetActive(false);
    }
}
