using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_php_3 : MonoBehaviour {

    public Text hint_1;
    public Text hint_2;
    public Text hint_3;
    public Text hint_4;
    public Text hint_5;

    hitbox_and_question_random range_1;

    void Start()
    {
        range_1 = GameObject.Find("Hint_Board").GetComponent<hitbox_and_question_random>();
    }

    void Update()
    {

        Debug.Log("First HINT :" + range_1.random_set_1);
        Debug.Log("Second HINT :" + range_1.random_set_2);
        Debug.Log("Third HINT :" + range_1.random_set_3);
        Debug.Log("Fourth HINT :" + range_1.random_set_4);
        Debug.Log("Fifth HINT :" + range_1.random_set_5);

        /*      HINT MESSAGE 1          */

        if (range_1.random_set_1 == 1)
        {
            hint_1.text = "FACT: When you use $_GET variable to collect data, the data will be visible to everyone.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: When you use $_POST variable to collect data, the data will be visible to only you.";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: GET should not be used while sending passwords or other sensitive information because the data is visible to everyone.";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: The strpos() function is used to search for a string or character within a string.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: You can set a parameter to have a default value if the function's caller doesn't pass it.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: PHP provides mysql_connect function to open a database connection.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT:  If you need to output something onto the screen you’ll need to use echo or print_r.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: Looping exist in PHP.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT:  There are two(2) main types of filtering: validation and sanitization.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: There are 16 error levels available in PHP.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: The description of Error level E_ERROR is Fatal run-time error.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT:  The twidle (~) character is used to represent the logical operator NOT.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: PHP version 5.2 introduced the function error_get_last().";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: There are 4 ways that session data be stored. Within flat files(files), within volatile memory(mm), using the SQLite database(sqlite), or through user defined functions(user).";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: session_start() is used for to start a session in PHP.";
        }

    }
}
