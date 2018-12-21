using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ma_Checker : MonoBehaviour {

	public GameObject Cplus_completed;
    public GameObject Java_completed;
    public GameObject PHP_completed;
    public GameObject ransom_completed;

    public GameObject Cplus_stage_1_completed;
    public GameObject Cplus_stage_2_completed;
    public GameObject Cplus_stage_3_completed;
    
    public GameObject Java_stage_1_completed;
    public GameObject Java_stage_2_completed;
    public GameObject Java_stage_3_completed;

    public GameObject PHP_stage_1_completed;
    public GameObject PHP_stage_2_completed;
    public GameObject PHP_stage_3_completed;


    void Update () {

        /*   CPLUS       */

        if (PlayerPrefs.GetString("quest_cplus_1") == "Completed" && PlayerPrefs.GetString("quest_cplus_2") == "Completed" && PlayerPrefs.GetString("quest_cplus_3") == "Completed")
        {
            Cplus_completed.SetActive(true);
        }

        else
        {
            Cplus_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_cplus_1") == "Completed")
        {
            Cplus_stage_1_completed.SetActive(true);
        }

        else
        {
            Cplus_stage_1_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_cplus_2") == "Completed")
        {
            Cplus_stage_2_completed.SetActive(true);
        }

        else
        {
            Cplus_stage_2_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_cplus_3") == "Completed")
        {
            Cplus_stage_3_completed.SetActive(true);
        }

        else
        {
            Cplus_stage_3_completed.SetActive(false);
        }



        /*   JAVA       */

        if (PlayerPrefs.GetString("quest_java_1") == "Completed" && PlayerPrefs.GetString("quest_java_2") == "Completed" && PlayerPrefs.GetString("quest_java_3") == "Completed")
        {
            Java_completed.SetActive(true);
        }

        else
        {
            Java_completed.SetActive(false);
        }


        if (PlayerPrefs.GetString("quest_java_1") == "Completed")
        {
            Java_stage_1_completed.SetActive(true);
        }

        else
        {
            Java_stage_1_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_java_2") == "Completed")
        {
            Java_stage_2_completed.SetActive(true);
        }

        else
        {
            Java_stage_2_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_java_3") == "Completed")
        {
            Java_stage_3_completed.SetActive(true);
        }

        else
        {
            Java_stage_3_completed.SetActive(false);
        }


        /*   PHP       */

        if (PlayerPrefs.GetString("quest_php_1") == "Completed" && PlayerPrefs.GetString("quest_php_2") == "Completed" && PlayerPrefs.GetString("quest_php_3") == "Completed")
        {
            PHP_completed.SetActive(true);
        }

        else
        {
            PHP_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_php_1") == "Completed")
        {
            PHP_stage_1_completed.SetActive(true);
        }

        else
        {
            PHP_stage_1_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_php_2") == "Completed")
        {
            PHP_stage_2_completed.SetActive(true);
        }

        else
        {
            PHP_stage_2_completed.SetActive(false);
        }

        if (PlayerPrefs.GetString("quest_php_3") == "Completed")
        {
            PHP_stage_3_completed.SetActive(true);
        }

        else
        {
            PHP_stage_3_completed.SetActive(false);
        }



        /*   RANSOMWARE       */

        if (PlayerPrefs.GetString("ransomware_quest") == "Completed")
        {
            ransom_completed.SetActive(true);
        }

        else
        {
            ransom_completed.SetActive(false);
        }


    }
}
