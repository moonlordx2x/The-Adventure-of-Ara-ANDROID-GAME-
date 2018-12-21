using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stringer : MonoBehaviour {

    private int damage;
    private float damage_2;
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
            damage = PlayerPrefs.GetInt("Stringer");
            heal.HP -= damage;

            if (heal.HP <= 0)
            {

                // gm[heal.id].SetActive(false)
               // Destroy(gm[heal.id]);
            }

        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            heal = col.GetComponent<Enemy_health>();
            damage = 1;
            heal.HP -= damage;

            if (heal.HP <= 0)
            {

                // gm[heal.id].SetActive(false)
               // Destroy(gm[heal.id]);
            }

        }
    }
}
