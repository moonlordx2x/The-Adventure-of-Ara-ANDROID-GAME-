using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Java_random : MonoBehaviour {

    // Set 1

    public GameObject first;
    public GameObject second;
    public GameObject third;

    // Set 2

    public GameObject fourth;
    public GameObject fifth;
    public GameObject six;

    // Set 3

    public GameObject seventh;
    public GameObject eigth;
    public GameObject nineth;

    // Set 4

    public GameObject tenth;
    public GameObject eleven;
    public GameObject twelve;

    // Set 5

    public GameObject thirteen;
    public GameObject fourteen;
    public GameObject fifteen;

    hitbox_and_question_random range_1;

    void Start()
    {
        range_1 = GameObject.Find("Hint_Board").GetComponent<hitbox_and_question_random>();
    }

    void Update()
    {

        switch (range_1.random_set_5)
        {
            case 13:
                thirteen.SetActive(true); break;
            case 14:
                fourteen.SetActive(true); break;
            case 15:
                fifteen.SetActive(true); break;
            default:
                thirteen.SetActive(false);
                fourteen.SetActive(false);
                fifteen.SetActive(false);
                break;
        }


        switch (range_1.random_set_4)
        {
            case 10:
                tenth.SetActive(true); break;
            case 11:
                eleven.SetActive(true); break;
            case 12:
                twelve.SetActive(true); break;
            default:
                tenth.SetActive(false);
                eleven.SetActive(false);
                twelve.SetActive(false);
                break;
        }


        switch (range_1.random_set_3)
        {
            case 7:
                seventh.SetActive(true); break;
            case 8:
                eigth.SetActive(true); break;
            case 9:
                nineth.SetActive(true); break;
            default:
                seventh.SetActive(false);
                eigth.SetActive(false);
                nineth.SetActive(false);
                break;
        }

        switch (range_1.random_set_2)
        {
            case 4:
                fourth.SetActive(true); break;
            case 5:
                fifth.SetActive(true); break;
            case 6:
                six.SetActive(true); break;
            default:
                fourth.SetActive(false);
                fifth.SetActive(false);
                six.SetActive(false);
                break;
        }

        switch (range_1.random_set_1)
        {
            case 1:
                first.SetActive(true); break;
            case 2:
                second.SetActive(true); break;
            case 3:
                third.SetActive(true); break;
            default:
                first.SetActive(false);
                second.SetActive(false);
                third.SetActive(false);
                break;
        }

    }
}
