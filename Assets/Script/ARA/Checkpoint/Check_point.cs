using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check_point : MonoBehaviour {

    public float player_progress_position;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Checkpoint_1");
            Debug.Log(player_progress_position);
            Progess_check.player_progress_position = player_progress_position;
        }
    }


}
