using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_3 : MonoBehaviour {

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
            hint_1.text = "FACT: The switch statement is used to choose the certain code to execute, So it is also called as selective structure.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT:  There are Three(3) types of loop. They are the While, Do while, and For loop.";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: There are two types of comments. They are double slash and slash started.";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: Comments are used to add meaning to the program and it is part of the source code disregarded by the compiler.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: single line and multi-line comments are supported in c++.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: The /* …. */ is used to write the multi line comment.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: the maximum number of arguments or parameters that can be present in one function call is 256.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: '#' symbol is used to declare the preprocessor directives.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT: the maximum number of parameters does a string constructor can take is 3. string( other_string, position, count ). It is a type of constructor for the string.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: Array first element start always at 0.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: An array is a series of elements of the same type in contiguous memory locations.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT: The array location starts from zero.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: array variable and values need to be declared after the datatype only. sample: int array[9];";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: The // is used to write the single line comment.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: In c++ you can use a nested loop statements.";
        }

    }
}
