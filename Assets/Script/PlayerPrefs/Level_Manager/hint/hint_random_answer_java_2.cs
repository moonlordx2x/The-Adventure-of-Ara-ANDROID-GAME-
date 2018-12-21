using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_java_2 : MonoBehaviour {

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
            hint_1.text = "FACT: Thread is not an abstract class.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: Abstract class cannot be directly initiated with new operator, Since abstract class does not contain any definition of implementation it is not possible to create an abstract object.";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: java.lang is a package that contains abstract keyword.";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: Precision is the advantage of BigDecimal over double.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: int, float, double provide overloaded methods for +,-,* and /. BigDecimal does not provide these overloaded methods.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: Base 10 is the base of BigDecimal data type.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: BigDecimal provides the following: (scale manipulation, rounding, hashing).";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: Operator new dynamically allocates memory for an object and returns a reference to it. This reference is address in memory of the object allocated by new.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT: Every class does not need to have a main() method, there can be only one main() method which is made public.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: Modulus operator can be applied to both integers and floating point numbers. ";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: decrement decreases value of variable by 1.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT: Assignment operators are more efficiently implemented by Java run-time system than their equivalent long forms. " + "Assignment operators run faster than their equivalent long forms. Assignment operators can be used only with numeric and character data type.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: 8 byte long data type can be automatically type cast to 4 byte float data type.";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: Return type of an method must be made void if it is not returning any value.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT:  main() method can be defined only once in a program. ";
        }

    }
}
