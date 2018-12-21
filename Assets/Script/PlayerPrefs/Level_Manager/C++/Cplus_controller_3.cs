using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cplus_controller_3 : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString("java", "active");
            Debug.Log("connected");
        }
    }
}
