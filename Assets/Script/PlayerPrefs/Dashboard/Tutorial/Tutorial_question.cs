using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_question : MonoBehaviour {

    public GameObject cplus_object;
    public GameObject world_quest;
    public GameObject stage_1;
    public GameObject stage_2;
    public GameObject stage_3;
    public GameObject stage_4;
    public GameObject ara;


    void Start()
    {
        world_quest.SetActive(false);
        ara.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            world_quest.SetActive(true);
            ara.SetActive(false);
            cplus_object.SetActive(false);
            gameObject.SetActive(false);
            stage_1.SetActive(false);
            stage_2.SetActive(false);
            stage_3.SetActive(false);
            stage_4.SetActive(false);

        }
    }
}
