using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_array : MonoBehaviour {

    public GameObject[] enemy_array;
    int total_enemy;

    void Start()
    {
        enemy_array = GameObject.FindGameObjectsWithTag("enemy");
    }

   
}
