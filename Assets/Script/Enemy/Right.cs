using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour {

     private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("Right Side");
        }

    }
}
