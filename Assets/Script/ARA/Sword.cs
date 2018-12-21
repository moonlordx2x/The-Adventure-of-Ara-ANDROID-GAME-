using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    private int damage;
	private float health;
	private string connect;

    public GameObject[] gm;

    public bool sword_detected = false;

    Enemy_health heal;

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "enemy")
        {
            heal = col.GetComponent<Enemy_health>();
            damage = PlayerPrefs.GetInt("Player_dmg");
			//Debug.Log (damage);
            heal.HP -= damage;
    

            if(heal.HP <= 0)
            {
               // gm[heal.id].SetActive(false);
                // gm[heal.id].SetActive(false)
              //  Destroy(gm[heal.id],2f);
            }
        }
    }




}
