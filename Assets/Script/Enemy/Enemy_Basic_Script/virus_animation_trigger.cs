using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus_animation_trigger : MonoBehaviour {

    public Animator enemyanimation;
    public bool player_detection = false;

    void Update()
    {
        enemyanimation.SetTrigger("Default");
        if (player_detection == true)
        {
            //enemyanimation.SetTrigger("Default");
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player_detection = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player_detection = true;
            enemyanimation.SetTrigger("Attack");
            enemyanimation.SetTrigger("Default");
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player_detection = false;
        }
    }
}
