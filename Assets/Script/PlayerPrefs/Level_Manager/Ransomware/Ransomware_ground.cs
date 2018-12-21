using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ransomware_ground : MonoBehaviour {

    public int total_enemy;
    public GameObject Gate_1;
    public GameObject Gate_2;
    public GameObject Gate_Entry;
    public Text text;

    public GameObject success;

    float timer = 3f;
    int coin;

    void Start()
    {
        Gate_Entry.SetActive(false);
        Gate_1.SetActive(true);
        Gate_2.SetActive(true);
        success.SetActive(false);
    }

    void Update()
    {
        if (total_enemy <= 0)
        {
            text.text = "CONGRATULATIONS";
            timer -= Time.deltaTime;
            Debug.Log(timer);
            if (timer <= 0)
            {

                coin = PlayerPrefs.GetInt("Pl_coin");
                success.SetActive(true);
                PlayerPrefs.SetString("ransomware_quest", "Completed");
                PlayerPrefs.SetInt("Pl_coin", coin + 600);
                PlayerPrefs.Save();
                timer = 3f;
            }
        }

        else if(total_enemy == 1)
        {
            Gate_Entry.SetActive(true);
            text.text = "THE GATE IS OPEN";

            
        }

        else
        {
            text.text = "Total enemy : " + total_enemy;
        }


    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("enemy found");
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("enemy not found");
            total_enemy -= 1;
        }
    }
}
