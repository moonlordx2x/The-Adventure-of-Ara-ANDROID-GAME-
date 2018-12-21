using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ground : MonoBehaviour {

    public int total_enemy;
    public GameObject quiz_gate;
    public Text text;

    void Start()
    {
        quiz_gate.SetActive(false);
    }

    void Update()
    {
        if (total_enemy <=0)
        {
            quiz_gate.SetActive(true);
            text.text = "THE GATE IS OPEN";
        }
        else
        {
            text.text = "Total enemy : " + total_enemy;
        }

       
    }


    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
         
            total_enemy -= 1;
        }
    }
}
