using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_canvas : MonoBehaviour {

    public bool wall = false;
    public bool wall_2 = false;
    public bool player = false;


    void FixedUpdate()
    {
        if (wall == false && wall_2 == false && player == false)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (wall == true && wall_2 == false && player == false)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
        else if (wall == false && wall_2 == true && player == false)
        {
            transform.localScale = new Vector2(1f, 1f);
        }

        else if (wall == true && wall_2 == false && player == true)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }

        else if (wall == false && wall_2 == true && player == true)
        {
            transform.localScale = new Vector2(1f, 1f);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "wall")
        {
            wall = true;
            wall_2 = false;
        }
        else if (col.gameObject.tag == "wall_2")
        {
            wall_2 = true;
            wall = false;
        }

       if (col.gameObject.tag == "Player")
        {
            player = true;
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Player_2" || col.gameObject.tag == "Player_2"|| col.gameObject.tag == "Player_2" )
        {
            player = false;
        }

    }

}
