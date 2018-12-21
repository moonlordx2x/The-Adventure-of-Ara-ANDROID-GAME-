using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {
    
    public Animator enemyanimation;
    public GameObject playertag;
    public float player_damage;
    public float player_health;
	public bool player_detection = false;

    public GameObject game_over_menu;

    // Update is called once per frame
    void Start()
    {
        game_over_menu.SetActive(false);
    }

	void FixedUpdate(){
		if (player_detection == true) {
			enemyanimation.SetTrigger ("Attack");
		} else {
			enemyanimation.SetTrigger ("Default");
		}
	}
    void OnTriggerEnter2D(Collider2D col)
    {
         if (col.gameObject.tag == "Player")
         {
            player_damage += Mathf.RoundToInt(Time.deltaTime);
			player_detection = true;
       
            if (player_damage >= 0) {
                enemyanimation.SetTrigger("Default");
            }
		 // Enemy Stored Damage
            playertag = GameObject.FindWithTag("Player");
            player_health -= player_damage;
            if (player_health <= 0) {
                playertag.SetActive(false);
                game_over();
            }
        }
        else { enemyanimation.SetTrigger("Default"); }
    }

    void game_over() {
        game_over_menu.SetActive(true);
        Time.timeScale = 0f;
    }
}
