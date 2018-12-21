using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_world : MonoBehaviour {

    public GameObject cplus_world;
    public GameObject java_world;
    public GameObject php_world;
    public GameObject ransomware;

    public GameObject java_world_locked;
    public GameObject php_world_locked;

    public GameObject cplus_stage_2_locked;
    public GameObject cplus_stage_3_locked;

    public GameObject java_stage_2_locked;
    public GameObject java_stage_3_locked;

    public GameObject php_stage_2_locked;
    public GameObject php_stage_3_locked;

    public GameObject ransomware_locked;

    public GameObject cplus_world_1;
    public GameObject cplus_world_2;
    public GameObject cplus_world_3;

    public GameObject java_world_1;
    public GameObject java_world_2;
    public GameObject java_world_3;

    public GameObject php_world_1;
    public GameObject php_world_2;
    public GameObject php_world_3;

    public GameObject back_main;
    public GameObject back_cplus;
    public GameObject back_java;
    public GameObject back_php;


    void Start () {
        cplus_world.SetActive(true);
        java_world.SetActive(false);
        php_world.SetActive(false);

        cplus_world_1.SetActive(false);
        cplus_world_2.SetActive(false);
        cplus_world_3.SetActive(false);

        java_world_1.SetActive(false);
        java_world_2.SetActive(false);
        java_world_3.SetActive(false);

        php_world_1.SetActive(false);
        php_world_2.SetActive(false);
        php_world_3.SetActive(false);

        ransomware.SetActive(false);

        back_main.SetActive(true);
        back_cplus.SetActive(false);
        back_java.SetActive(false);
        back_php.SetActive(false);

    }

    void Update()
    {
        if(PlayerPrefs.GetString("java") == "Active")
        {
            java_world_locked.SetActive(false);
        }
        else
        {
            java_world_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("php") == "Active")
        {
            php_world_locked.SetActive(false);
        }
        else
        {
            php_world_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("cplus_2") == "Active")
        {
            cplus_stage_2_locked.SetActive(false);
        }
        else
        {
            cplus_stage_2_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("cplus_3") == "Active")
        {
            cplus_stage_3_locked.SetActive(false);
        }
        else
        {
            cplus_stage_3_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("java_2") == "Active")
        {
            java_stage_2_locked.SetActive(false);
        }
        else
        {
            java_stage_2_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("java_3") == "Active")
        {
            java_stage_3_locked.SetActive(false);
        }
        else
        {
            java_stage_3_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("php_2") == "Active")
        {
            php_stage_2_locked.SetActive(false);
        }
        else
        {
            php_stage_2_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("php_3") == "Active")
        {
            php_stage_3_locked.SetActive(false);
        }
        else
        {
            php_stage_3_locked.SetActive(true);
        }

        if (PlayerPrefs.GetString("ransomware") == "Active")
        {
            ransomware_locked.SetActive(false);
            Debug.Log("Success");
        }
        else
        {
            ransomware_locked.SetActive(true);
        }
    }

    /* WORLD SELECTOR */

    public void cplus_main_world()
    {
        cplus_world.SetActive(true);
        java_world.SetActive(false);
        php_world.SetActive(false);
        ransomware.SetActive(false);
    }

    public void java_main_world()
    {
        cplus_world.SetActive(false);
        java_world.SetActive(true);
        php_world.SetActive(false);
        ransomware.SetActive(false);
    }

    public void php_main_world()
    {
        cplus_world.SetActive(false);
        java_world.SetActive(false);
        php_world.SetActive(true);
        ransomware.SetActive(false);
    }

    public void ransom_main_world()
    {
        cplus_world.SetActive(false);
        java_world.SetActive(false);
        php_world.SetActive(false);
        ransomware.SetActive(true);
    }

    public void close_main_world()
    {
        this.gameObject.SetActive(false);
    }


    /* C++ World Stage Selector*/

    public void cplus_stage_1()
    {
        cplus_world_1.SetActive(true);
        cplus_world_2.SetActive(false);
        cplus_world_3.SetActive(false);

        back_main.SetActive(false);
        back_cplus.SetActive(true);
        back_java.SetActive(false);
        back_php.SetActive(false);
    }

    public void cplus_stage_2()
    {
        cplus_world_1.SetActive(false);
        cplus_world_2.SetActive(true);
        cplus_world_3.SetActive(false);
    }

    public void cplus_stage_3()
    {
        cplus_world_1.SetActive(false);
        cplus_world_2.SetActive(false);
        cplus_world_3.SetActive(true);
    }

    public void cplus_stage_close()
    {
        cplus_world_1.SetActive(false);
        cplus_world_2.SetActive(false);
        cplus_world_3.SetActive(false);

        back_main.SetActive(true);
        back_cplus.SetActive(false);
        back_java.SetActive(false);
        back_php.SetActive(false);
    }

    /* JAVA World Stage Selector*/

    public void java_stage_1()
    {
        java_world_1.SetActive(true);
        java_world_2.SetActive(false);
        java_world_3.SetActive(false);

        back_main.SetActive(false);
        back_cplus.SetActive(false);
        back_java.SetActive(true);
        back_php.SetActive(false);
    }

    public void java_stage_2()
    {
        java_world_1.SetActive(false);
        java_world_2.SetActive(true);
        java_world_3.SetActive(false);
    }

    public void java_stage_3()
    {
        java_world_1.SetActive(false);
        java_world_2.SetActive(false);
        java_world_3.SetActive(true);
    }

    public void java_stage_close()
    {
        java_world_1.SetActive(false);
        java_world_2.SetActive(false);
        java_world_3.SetActive(false);

        back_main.SetActive(true);
        back_cplus.SetActive(false);
        back_java.SetActive(false);
        back_php.SetActive(false);
    }

    /* PHP World Stage Selector*/

    public void php_stage_1()
    {
        php_world_1.SetActive(true);
        php_world_2.SetActive(false);
        php_world_3.SetActive(false);

        back_main.SetActive(false);
        back_cplus.SetActive(false);
        back_java.SetActive(false);
        back_php.SetActive(true);
    }

    public void php_stage_2()
    {
        php_world_1.SetActive(false);
        php_world_2.SetActive(true);
        php_world_3.SetActive(false);
    }

    public void php_stage_3()
    {
        php_world_1.SetActive(false);
        php_world_2.SetActive(false);
        php_world_3.SetActive(true);
    }

    public void php_stage_close()
    {
        php_world_1.SetActive(false);
        php_world_2.SetActive(false);
        php_world_3.SetActive(false);

        back_main.SetActive(true);
        back_cplus.SetActive(false);
        back_java.SetActive(false);
        back_php.SetActive(false);
    }

}
