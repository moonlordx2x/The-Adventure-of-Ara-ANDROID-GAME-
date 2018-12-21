using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_2 : MonoBehaviour {

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
            hint_1.text = "FACT: 'cin' is an object of istream class.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: Templates are the foundation of generic programming, which involves writing code in a way that is independent of any particular type.";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: The size of wchar_t in c++ will based on the number of bits in the system. ";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: void is used to represent the absence of parameters.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: double or float data type is used when the value has decimals.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: In C++, The sign of a character data type by default is Implementation Dependent.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: '&' is used to define reference variable.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: The void pointer can point to int, float and double.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT: The data elements in the structure are also known as members.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: ';' or terminator is used when terminating a structure.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: it will not allocate any memory when the structure is declared. While the structure is declared, it will not be initialized, So it will not allocate any memory.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT: The declaration of the structure is also called as structure specifier. The structure declaration with open and close braces and with a semicolon is also called structure specifier.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: ?: operator means conditional. In this operator, if the condition is true means, it will return the first operator, otherwise second operator.";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: There are five(5) sequences of statements. They are Preprocessor directives, Comments, Declarations, Function Declarations, Executable statements.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: The if..else statement can be replaced by conditional operator.";
        }

    }
}
