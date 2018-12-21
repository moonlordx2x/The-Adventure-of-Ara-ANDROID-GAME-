using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_php_2 : MonoBehaviour {

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
            hint_1.text = "FACT: A backslash is used so that the dollar sign is treated as a normal string character rather than prompt PHP to treat as a variable. The backslash used in this manner is known as escape character.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: Rasmus Lerdorf created the PHP scripting language.";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "Fact: PHP is used for web development.";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: function functionName(parameters) { function body } is the right way to declare a function in PHP.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: Type Hinting was introduced in PHP version 5.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: Function statements exist in PHP.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: Rasmus Lerdorf is the father PHP.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT:  uniqueid() is the function used to generate unique ids.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT: gzcompress() is the function used to compress a string";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: Like many programming languages, the first element of an array has an index value of 0.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: Arrays Exist in PHP language.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT: is_array() is the function  that will  return true if a variable is an array or false if it is not.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: array_push adds a value to the end of an array, returning the total count of elements in the array after the new value has been added.";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: prev() is the function that can be used to move the pointer to the previous array position.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: sort() function is used to sort in ascending order whereas rsort() meaning reverse sort is used for sorting in descending order.";
        }

    }
}
