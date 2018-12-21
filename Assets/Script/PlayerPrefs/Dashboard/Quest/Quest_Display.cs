using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest_Display : MonoBehaviour {

    public GameObject cplus_quest_1;
    public GameObject cplus_quest_2;
    public GameObject cplus_quest_3;

    
    public GameObject java_quest_1;
    public GameObject java_quest_2;
    public GameObject java_quest_3;

    public GameObject php_quest_1;
    public GameObject php_quest_2;
    public GameObject php_quest_3;

    public GameObject ransomware;

    public Text quest_status;

    void Start () {

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);
        
        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);

        ransomware.SetActive(false);
    }


    public void cplus()
    {
        if (PlayerPrefs.GetString("quest_cplus_1") == "Incompleted")
        {
            quest_status.text = "C++ WORLD 1 QUEST ";
        }
        else
        {
            quest_status.text = "C++ WORLD 1 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(true);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);
    }

    public void cplus_2()
    {

        if (PlayerPrefs.GetString("quest_cplus_2") == "Incompleted")
        {
            quest_status.text = "C++ WORLD 2 QUEST ";
        }
        else
        {
            quest_status.text = "C++ WORLD 2 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(true);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);

    }

    public void cplus_3()
    {

        if (PlayerPrefs.GetString("quest_cplus_3") == "Incompleted")
        {
            quest_status.text = "C++ WORLD 3 QUEST ";
        }
        else
        {
            quest_status.text = "C++ WORLD 3 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(true);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);

    }

    public void java()
    {
        if (PlayerPrefs.GetString("quest_java_1") == "Incompleted")
        {
            quest_status.text = "JAVA WORLD 1 QUEST ";
        }
        else
        {
            quest_status.text = "JAVA WORLD 1 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(true);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);
    }

    public void java_2()
    {

        if (PlayerPrefs.GetString("quest_java_2") == "Incompleted")
        {
            quest_status.text = "JAVA WORLD 2 QUEST ";
        }
        else
        {
            quest_status.text = "JAVA WORLD 2 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(true);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);

    }

    public void java_3()
    {

        if (PlayerPrefs.GetString("quest_java_3") == "Incompleted")
        {
            quest_status.text = "JAVA WORLD 3 QUEST ";
        }
        else
        {
            quest_status.text = "JAVA WORLD 3 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(true);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);

    }

    public void php()
    {
        if (PlayerPrefs.GetString("quest_php_1") == "Incompleted")
        {
            quest_status.text = "PHP WORLD 1 QUEST ";
        }
        else
        {
            quest_status.text = "PHP WORLD 1 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(true);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);
    }

    public void php_2()
    {
        Debug.Log(PlayerPrefs.GetString("quest_php_1"));
        Debug.Log(PlayerPrefs.GetString("quest_php_2"));
        Debug.Log(PlayerPrefs.GetString("quest_php_3"));

        if (PlayerPrefs.GetString("quest_php_2") == "Incompleted")
        {
            quest_status.text = "PHP WORLD 2 QUEST ";
        }
        else
        {
            quest_status.text = "PHP WORLD 2 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(true);
        php_quest_3.SetActive(false);
        ransomware.SetActive(false);

    }

    public void php_3()
    {

        if (PlayerPrefs.GetString("quest_php_3") == "Incompleted")
        {
            quest_status.text = "PHP WORLD 3 QUEST ";
        }
        else
        {
            quest_status.text = "PHP WORLD 3 QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(true);
        ransomware.SetActive(false);

    }

    public void ransomware_1()
    {
        
        if (PlayerPrefs.GetString("ransomware_quest") == "Incompleted")
        {
            quest_status.text = "RANSOMWARE QUEST ";
        }
        else
        {
            Debug.Log(PlayerPrefs.GetString("ransomware_quest"));
            quest_status.text = "RANSOMWARE QUEST (COMPLETED)";
        }

        cplus_quest_1.SetActive(false);
        cplus_quest_2.SetActive(false);
        cplus_quest_3.SetActive(false);

        java_quest_1.SetActive(false);
        java_quest_2.SetActive(false);
        java_quest_3.SetActive(false);

        php_quest_1.SetActive(false);
        php_quest_2.SetActive(false);
        php_quest_3.SetActive(false);
        ransomware.SetActive(true);

    }



}
