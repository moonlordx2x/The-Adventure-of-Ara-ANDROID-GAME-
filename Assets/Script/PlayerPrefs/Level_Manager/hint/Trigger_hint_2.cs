using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_hint_2 : MonoBehaviour {

    public GameObject hint_question;
    public GameObject hint_box;

    Trigger_hint trigger;

    void Start () {
        hint_question.SetActive(true);
        hint_box.SetActive(true);
        trigger = GameObject.Find("HINT_CONTAINER_C++_Triggered").GetComponent<Trigger_hint>();
    }
	
	
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            hint_question.SetActive(false);
            hint_box.SetActive(false);
            trigger.trigger_hint = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            hint_question.SetActive(false);
            hint_box.SetActive(false);
            trigger.trigger_hint = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            hint_question.SetActive(true);
            hint_box.SetActive(true);
            trigger.trigger_hint = false;
        }
    }
}
