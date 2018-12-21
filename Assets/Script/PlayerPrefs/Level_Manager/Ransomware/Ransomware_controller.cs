using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ransomware_controller : MonoBehaviour {

    public GameObject ransom_object;
    public GameObject ara_default;
    public GameObject ara_cplus;
    public GameObject ara_php;
    public GameObject ara_java;

    public GameObject Gate_1;
    public GameObject Gate_2;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Gate_1.SetActive(false);
            Gate_2.SetActive(false);
            gameObject.SetActive(false);

        }
    }
}
