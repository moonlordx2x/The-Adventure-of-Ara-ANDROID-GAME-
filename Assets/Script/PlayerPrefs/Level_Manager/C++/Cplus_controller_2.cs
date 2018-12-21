using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cplus_controller_2 : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString("cplus_3", "active");
            Debug.Log("connected");
        }
    }
}
