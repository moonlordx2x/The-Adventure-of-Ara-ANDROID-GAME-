using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_checker : MonoBehaviour {

    public bool checkering_ground;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            checkering_ground = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            checkering_ground = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            checkering_ground = false;
        }
    }



}
