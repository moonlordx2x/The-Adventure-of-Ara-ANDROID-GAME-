using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_move : MonoBehaviour {

	public bool wall = false;
    public bool wall_2 = false;

	void FixedUpdate()
    {
		if (wall == false && wall_2 == false) {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if(wall == true && wall_2 == false) {
			transform.localScale = new Vector2 (-1f, 1f);
		}
        else if (wall == false && wall_2 == true)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.tag == "wall"){
			wall = true;
            wall_2 = false;

		}
        else if (col.gameObject.tag == "wall_2")
        {
            wall_2 = true;
            wall = false;

        }
    }
}
