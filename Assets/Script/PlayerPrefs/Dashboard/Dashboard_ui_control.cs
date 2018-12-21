using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dashboard_ui_control : MonoBehaviour {

    public GameObject Map;
    public GameObject Upgrade;
    public GameObject Craft;
    public GameObject Equipment;
    public GameObject Quest;
    public GameObject Credit;
    public GameObject Setting;

    void Start()
    {
        Map.SetActive(false);
        Upgrade.SetActive(false);
        Craft.SetActive(false);
        Equipment.SetActive(false);
        Quest.SetActive(false);
        Credit.SetActive(false);
        Setting.SetActive(false);
    }

    public void Map_UI()
    {
        Map.SetActive(true);
    }

    public void Upgrade_UI()
    {
        Upgrade.SetActive(true);
    }

    public void Craft_UI()
    {
        Craft.SetActive(true);
    }

    public void Equip_UI()
    {
        Equipment.SetActive(true);
    }

    public void Quest_UI()
    {
        Quest.SetActive(true);
    }

    public void Credit_UI()
    {
        Credit.SetActive(true);
    }

    public void Setting_UI()
    {
        Setting.SetActive(true);
    }

    public void Close_UI()
    {
        Map.SetActive(false);
        Upgrade.SetActive(false);
        Craft.SetActive(false);
        Equipment.SetActive(false);
        Quest.SetActive(false);
        Credit.SetActive(false);
        Setting.SetActive(false);
    }

}
