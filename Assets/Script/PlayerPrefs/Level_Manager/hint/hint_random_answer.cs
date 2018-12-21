using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer : MonoBehaviour {


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

    void Update () {

     //   Debug.Log("First HINT :" + range_1.random_set_1);
     //   Debug.Log("Second HINT :" + range_1.random_set_2);
    //    Debug.Log("Third HINT :" + range_1.random_set_3);
   //     Debug.Log("Fourth HINT :" + range_1.random_set_4);
    //    Debug.Log("Fifth HINT :" + range_1.random_set_5);

        /*      HINT MESSAGE 1          */

        if (range_1.random_set_1 == 1) {
            hint_1.text = "FACT: The cin>> input statement is used to receive data from keyboard.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: The cout<< output statement is used to print text on the screen.";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: C++ program can`t have many main functions. Only Read Only One Main function";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: Comments in c++ language starts with /* and ends with */.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: There are five basic data types associated with variables. (int, float, double, char, void).";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: An integer type (sometimes called an integral type) variable is a variable that can only hold non-fractional numbers (e.g. -2, -1, 0, 1, 2). C++ has five different fundamental integer types available for use: Category.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: An expression is " + "''a sequence of operators and operands that specifies a computation''"+"(that's the definition given in the C++ standard)."
            +" Examples are 42, 2 + 2, "+"''hello, world''"+", and func("+"argument"+").Assignments are expressions in C++; so are function calls.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: Logical operators: (&&) - Called Logical AND operator. If both the operands are non-zero, then condition becomes true. (A && B) is false.   (||) - Called Logical OR Operator.If any of the two operands is non - zero, then condition becomes true. (A || B) is true.    (!) - Called Logical NOT Operator.Use to reverses the logical state of its operand.If a condition is true, then Logical NOT operator will make false.!(A && B) is true.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = " FACT: Comparison Operator: (==) - Checks if the values of two operands are equal or not, if yes then condition becomes true. (A == B) is not true. (!=) - Checks if the values of two operands are equal or not, if values are not equal then condition becomes true. (A != B) is true. (>) - Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true. (A > B) is not true. (<) - Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true. (A < B) is true. (>=) - Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true. (A >= B) is not true. (<=) - Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true. (A <= B) is true.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: A loop is a sequence of instructions that is continually repeated until a certain condition is reached.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: C++ break command. When the break statement is encountered inside a loop, the loop is immediately terminated and program control resumes at the next statement following the loop.It can be used to terminate a case in the switch statement. ";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT: A two-dimensinal array represents data in the form of table with rows and columns.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: if statements is used for decision or conditional statement of a system.";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: the purpose of using functions in C++ language is to do specific task. A function declaration tells the compiler about a function's name, return type, and parameters.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: In C++, we can`t declare a structure using ''structure'' keyword. C++ supports classes (and in C++ a struct is a special case of a class), and C does not. However, as you can see without language support for classes, implementing then can become tiresome.Because C standard does not allow to declare function / method inside a structure.C is not object-oriented language.";
        }

    }

}
