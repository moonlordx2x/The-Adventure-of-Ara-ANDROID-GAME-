using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_java_3 : MonoBehaviour {

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
            hint_1.text = "FACT: All object of class share a single copy of methods defined in a class, Methods are allotted memory only once. All the objects of the class have access to methods of that class are allotted memory only for the variables not for the methods.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: Switch statements checks for equality between the controlling variable and its constant cases.";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: Continue and break are jump statements, and for is an looping statement. if() is for selection statements or condition.";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: Enum cannot have any modifiers. They are public, static and final by default.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: ''continue'' keyword can skip processing remainder of code in its body for a particular iteration.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: No two case constants in the same switch can have identical values.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: While loop repeats a set of code only until condition is met.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: Break halts the execution and forces the control out of the loop.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT: Do statement checks the condition at the end of the loop. Hence, code gets executed at least once.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: Break is used with switch statement to shift control out of switch.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: do-while is an iteration statement. Others are decision making statements.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT: Goto is marked as not used in Java.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: The break statement causes an exit from innermost loop or switch.";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: java.util.Scanner is a simple text scanner which can parse primitive types and strings using regular expressions.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: Method chain is also known as parameter idiom.";
        }

    }
}
