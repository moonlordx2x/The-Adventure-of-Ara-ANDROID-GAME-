using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_health : MonoBehaviour {
    public int HP;
    public int id;

    int coin;

    public GameObject blood;

   // Ground Game_Platforms;

    float position_y;
    void Start()
    {
        position_y = 5f;
        //Game_Platforms = GameObject.Find("Game_Platform").GetComponent<Ground>();
    }

    void Update()
    {

        coin = PlayerPrefs.GetInt("Pl_coin");
        if (HP <=0)
        {
            Blood();
            PlayerPrefs.SetInt("Pl_coin", coin + 5);
            PlayerPrefs.Save();

            if (this.name == "Ransom_ware")
            {
                PlayerPrefs.SetString("ransomware_quest", "Completed");
            }
            //Game_Platforms.total_enemy -=1;
        }  
    }

    void Blood()
    {
        Instantiate(blood, new Vector2(transform.position.x, position_y), Quaternion.identity);
        Destroy(gameObject);
    }
}


