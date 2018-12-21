using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cplus_controller : MonoBehaviour {

    public GameObject cplus_object;
    public GameObject world_quest;
    public GameObject ara_default;
    public GameObject ara_cplus;
    public GameObject ara_php;
    public GameObject ara_java;
    public GameObject question_counter;

    void Start()
    {
        question_counter.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {

            world_quest.SetActive(true);
            question_counter.SetActive(true);

            cplus_object.SetActive(false);
            gameObject.SetActive(false);
            ara_default.SetActive(false);
            ara_cplus.SetActive(false);
            ara_php.SetActive(false);
            ara_java.SetActive(false);

        }
    }

}
