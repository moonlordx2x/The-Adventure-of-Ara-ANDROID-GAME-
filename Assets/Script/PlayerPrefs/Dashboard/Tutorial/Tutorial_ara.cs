using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Tutorial_ara : MonoBehaviour {

    public Rigidbody2D rb;
    private float speed = 17f;
    private float move = 0f;
    public Animator animate;

    public float countdown = 1.0f;
    public float attack = 1.0f;

    ground_checker ground_check;
    Skill_checker checkers;

    GameObject sword;


    //Skills
    public bool stringer_skill = false;
    GameObject Stringer_button;
    soundmanager sound_manager;

    //Cooldown
    public bool stringer_cooldown = false;
    GameObject Stringer_cooldown;
    Cooldown_and_Skill_Checker cooldown_skill;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
    
    }


    void Update()
    {
        player_movement();


        if (move < 0 || Input.GetKey("a")) { transform.localScale = new Vector2(-1f, 1f); countsdown(); }
        else if (move > 0 || Input.GetKey("d")) { transform.localScale = new Vector2(1f, 1f); countsdown(); }
        else { animate.SetTrigger("default"); countdown = 1.0f; }




        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            attacking();
            animate.SetTrigger("attack");
            Debug.Log("Active Attack");
        }
        

    }

    void countsdown()
    {
        countdown += Time.deltaTime;
        if (countdown <= 1.2) { animate.SetTrigger("running_tap"); }
        else { animate.SetTrigger("running_hold"); }
    }

    void attacking()
    {
        attack += Time.deltaTime;
        //Debug.Log (attack);
    }


    void player_movement()
    {
        move = CrossPlatformInputManager.GetAxis("Horizontal");
        //move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }
}
