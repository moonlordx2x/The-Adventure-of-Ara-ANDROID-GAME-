using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Binary_rain : MonoBehaviour {

    private int damage;
    private float health;
    private string connect;

    public GameObject[] gm;

    Enemy_health heal;

    void Start()
    {
      
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            heal = col.GetComponent<Enemy_health>();
            damage = PlayerPrefs.GetInt("Binary_rain");
            heal.HP -= damage;
 
            if (heal.HP <= 0)
            {

                // gm[heal.id].SetActive(false)
               // Destroy(gm[heal.id]);
            }

        }
    }
    
}
