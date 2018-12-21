using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip_set : MonoBehaviour {

    public GameObject cplus_set;
    public GameObject java_set;
    public GameObject php_set;


    void Start () {
        cplus_set.SetActive(false);
        java_set.SetActive(false);
        php_set.SetActive(false);

    }
	

    public void cplus_set_equip()
    {
        cplus_set.SetActive(true);
        java_set.SetActive(false);
        php_set.SetActive(false);
    }

    public void java_set_equip()
    {
        cplus_set.SetActive(false);
        java_set.SetActive(true);
        php_set.SetActive(false);
    }

    public void php_set_equip()
    {
        cplus_set.SetActive(false);
        java_set.SetActive(false);
        php_set.SetActive(true);
    }

}
