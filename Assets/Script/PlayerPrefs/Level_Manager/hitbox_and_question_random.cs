using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox_and_question_random : MonoBehaviour
{

    //set 1
    public int random_set_1;

    //set 2
    public int random_set_2;

    //set 3
    public int random_set_3;

    //set 4
    public int random_set_4;

    //set 5
    public int random_set_5;


    void Start()
    {
        random_set_1 = Random.Range(1, 4);
        random_set_2 = Random.Range(4, 7);
        random_set_3 = Random.Range(7, 10);
        random_set_4 = Random.Range(10, 13);
        random_set_5 = Random.Range(13, 16);

    }
}
