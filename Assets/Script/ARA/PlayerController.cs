using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb;
	private float speed = 17f;
	private float move = 0f;
	public Animator animate;
    
    public float countdown = 1.0f;
	public float attack = 1.0f;

    ground_checker ground_check;
    Skill_checker checkers;

    GameObject sword;

    public bool movement_player;

    //Skills
    public bool stringer_skill = false;
    GameObject Stringer_button;
    soundmanager sound_manager;

    //Cooldown
    public bool stringer_cooldown = false;
    GameObject Stringer_cooldown;
    Cooldown_and_Skill_Checker cooldown_skill;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
        ground_check = GetComponentInChildren<ground_checker>();

        Stringer_button = GameObject.Find("Stringer_cooldown");
        sound_manager = GameObject.Find("Sound_and_button_manager").GetComponent<soundmanager>();


        cooldown_skill = GameObject.Find("Skill_cooldown_manager").GetComponent<Cooldown_and_Skill_Checker>();

    }
	
	
	void Update () {
  
        //if (ground_check.checkering_ground == false || checkers.checker_skill == true)
        if (sound_manager.binary_rain_triggered == true || sound_manager.eyeplus_triggered == true || sound_manager.fire_switch_triggered == true || sound_manager.stringer_triggered == true)
        {
            player_disable();
        }
        else
        {
            player_movement();
        }

        if (Time.timeScale == 0f)
        {
            //animate.SetTrigger("default");
            countdown = 1.0f;
            speed = 0f;
            move = 0f;
        }
        else
        {
          //  Input.ResetInputAxes();
        }

        if (move < 0 || Input.GetKey("a")) { transform.localScale = new Vector2(-1f, 1f); countsdown(); movement_player = true; }
        else if (move > 0 || Input.GetKey("d")) { transform.localScale = new Vector2(1f, 1f); countsdown(); movement_player = false; }
        else { animate.SetTrigger("default"); countdown = 1.0f; }

 

        
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")){
			attacking();
			animate.SetTrigger("attack");
            Debug.Log("Active Attack");
        }
        //binary_rain
        else if (CrossPlatformInputManager.GetButtonDown("binary_rain"))
        {
            animate.SetTrigger("binary_rain");
            cooldown_skill.binaryrain_cooldown = true;
            sound_manager.binary_rain_triggered = true;
            Debug.Log("Active Binary");
        }
        else if (CrossPlatformInputManager.GetButtonDown("Eye++"))
        {
            animate.SetTrigger("eyeplus");
            cooldown_skill.eyeplus_cooldown = true;
            sound_manager.eyeplus_triggered = true;
        }

        else if(CrossPlatformInputManager.GetButtonDown("FireSwitch"))
        {
            animate.SetTrigger("fireswitch");
            sound_manager.fire_switch_triggered = true;
            cooldown_skill.fireswitch_cooldown = true;
        }
        else if(CrossPlatformInputManager.GetButtonDown("Stringer"))
        {
            animate.SetTrigger("stringer");
            cooldown_skill.stringer_cooldown = true;
            sound_manager.stringer_triggered = true;
        }

    }

    void countsdown()
    {
        countdown += Time.deltaTime;
        if (countdown <= 1.2) { animate.SetTrigger("running_tap"); }
        else{ animate.SetTrigger("running_hold"); }
    }

	void attacking(){
		attack += Time.deltaTime;
		//Debug.Log (attack);
	}


    void player_movement()
    {
        move = CrossPlatformInputManager.GetAxis("Horizontal");
        //move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
        speed = 17f;
    }

    void player_disable()
    {
        //move = CrossPlatformInputManager.GetAxis("Horizontal");
        //move = Input.GetAxis("Horizontal");
        move = 0;
        speed = 0f;
        Input.ResetInputAxes();
        rb.velocity = Vector2.zero;
    }

}
