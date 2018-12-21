using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour {

    public float speed;
    public float step;
    public bool wall = false;
    public bool wall_2 = false;
    public bool playerdetect = false;
    Transform Player;
    PlayerController PC;
    float distance;

    bool right;
    bool left;

    void FixedUpdate() {

        step = speed * Time.deltaTime;

        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        distance = Vector2.Distance(transform.position, Player.position);

        /*

       if (wall == false && wall_2 == false && playerdetect == false)
       {
           transform.position += Vector3.left * step;
       }
       else if (wall == true && wall_2 == false && playerdetect == false)
       {
           transform.position += Vector3.right * step;
           transform.localScale = new Vector2(-1f, 1f);
       }
       else if (wall == false && wall_2 == true && playerdetect == false)
       {
           transform.position += Vector3.left * step;
           transform.localScale = new Vector2(1f, 1f);
       }


       else if (wall == false && wall_2 == false && playerdetect == true)
       {
           transform.position = Vector3.MoveTowards(transform.position, new Vector2(Player.position.x + 12f, transform.position.y), speed * Time.deltaTime);
       }
       else if (wall == true && wall_2 == false && playerdetect == true)
       { 
           transform.position = Vector3.MoveTowards(transform.position, new Vector2(Player.position.x - 12f, transform.position.y), speed * Time.deltaTime);
       }
       else if (wall == false && wall_2 == true && playerdetect == true)
       {

           transform.position = Vector3.MoveTowards(transform.position, new Vector2(Player.position.x + 12f, transform.position.y), speed * Time.deltaTime);
       }
       */


        Debug.Log(PC.movement_player);
        if (PC.movement_player == false && playerdetect == true && right == true && left == false)
        {
            transform.localScale = new Vector2(1f, 1f);
            transform.position = Vector3.MoveTowards(transform.position, new Vector2(Player.position.x + 12f, transform.position.y), speed * Time.deltaTime);
        }
        else if (PC.movement_player == true && playerdetect == true && right == true && left == false)
        {
            transform.localScale = new Vector2(-1f, 1f);
            transform.position = Vector3.MoveTowards(transform.position, new Vector2(Player.position.x - 12f, transform.position.y), speed * Time.deltaTime);
        }


        else if (PC.movement_player == true && playerdetect == true && left == true && right == false)
        {
            transform.localScale = new Vector2(-1f, 1f);
            transform.position = Vector3.MoveTowards(transform.position, new Vector2(Player.position.x - 12f, transform.position.y), speed * Time.deltaTime);
        }

        else if (PC.movement_player == false && playerdetect == true && left == true && right == false)
        {
            transform.localScale = new Vector2(1f, 1f);
            transform.position = Vector3.MoveTowards(transform.position, new Vector2(Player.position.x + 12f, transform.position.y), speed * Time.deltaTime);
        }
        else
        {
            if (wall == false && wall_2 == false && playerdetect == false)
            {
                transform.position += Vector3.left * step;
            }
            else if (wall == true && wall_2 == false && playerdetect == false)
            {
                transform.position += Vector3.right * step;
                transform.localScale = new Vector2(-1f, 1f);
            }
            else if (wall == false && wall_2 == true && playerdetect == false)
            {
                transform.position += Vector3.left * step;
                transform.localScale = new Vector2(1f, 1f);
            }
        }


    }

    private void OnTriggerEnter2D(Collider2D col) {
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
        else if (col.CompareTag("Player"))
        {
           // Debug.Log("Player Space ");
            playerdetect = true;
        }

        if (col.gameObject.tag == "right")
        {
            right = true;
            left = false;

            Debug.Log("Player Right ");
        }
        else if (col.gameObject.tag == "left")
        {
            Debug.Log("Player Left ");
            right = false;
            left = true;
        }

    }

    

    private void OnTriggerExit2D(Collider2D col)
    {
     
        if (col.CompareTag("Player"))
        {
            playerdetect = false;
        }

        if (col.gameObject.tag == "right")
        {
            right = false;

            Debug.Log("Player Right Exit");
        }
        else if (col.gameObject.tag == "left")
        {
            Debug.Log("Player Left Exit");
            left = false;
        }
    }
}
