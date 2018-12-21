using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ransomware_animation : MonoBehaviour {

    public Animator enemyanimation;
    public bool player_detection = false;
    int random;

    void Update()
    {
        enemyanimation.SetTrigger("Running");
        if (player_detection == false)
        {
            enemyanimation.SetTrigger("Running");
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
                //enemyanimation.SetTrigger("Attack");
                enemyanimation.SetTrigger("Attack_2");
                player_detection = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemyanimation.SetTrigger("Attack");
            //enemyanimation.SetTrigger("Attack_2");
            player_detection = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enemyanimation.SetTrigger("Running");
            player_detection = false;
        }
    }
}
