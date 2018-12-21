using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class design_movement : MonoBehaviour {

    public float speed;
    public float step;
    public bool wall = false;
    public bool wall_2 = false;

    
    void Start()
    {
        step = speed * Time.deltaTime;
    }

    void Update()
    {
        if (wall == false && wall_2 == false)
        {
            transform.position += Vector3.left * step;
        }
        else if (wall == true && wall_2 == false)
        {
            transform.position += Vector3.right * step;
            transform.localScale = new Vector2(-1f, 1f);
        }
        else if (wall == false && wall_2 == true)
        {
            transform.position += Vector3.left * step;
            transform.localScale = new Vector2(1f, 1f);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("hello world");

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

        if (col.gameObject.tag == "platform")
        {
            Debug.Log("hello");
        }
    }
    
}
