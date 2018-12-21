using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_java : MonoBehaviour {

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
            hint_1.text = "FACT: Local variables are not assigned any value by default.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: The int data type is represented by 32-bit signed two's complement integer, Minimum value: -231 Maximum value: 231 - 1";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: In Java, Try statements can be nested.";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "FACT: long variable has default value of 0L if defined as an instance/static variable.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: An expression involving bytes, ints, shorts, literal numbers, the entire expression is promoted to int before any calculation is done.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT:  Short data type occupies 16 bits in memory. Its range is from -32768 to 32767.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: Byte datatype occupies 8 bits in memory. Its range is from -128 to 127.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: 8 byte long data type can be automatically type cast to 4 byte float data type.";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT:  Return type of an method must be made void if it is not returning any value.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: Function overloading is a process of defining more than one method in a class with same name differentiated by function signature i:e return type or parameters type and number. Example – int volume(int length, int width) &int volume(int length, int width, int height) can be used to calculate volume.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT:  A constructor is a method that initializes an object immediately upon creation. It has the same name as that of class in which it resides.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "FACT: main() method can be defined only once in a program. Program execution begins from the main() method by java runtime system.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: All object of class share a single copy of methods defined in a class, Methods are allotted memory only once. All the objects of the class have access to methods of that class are allotted memory only for the variables not for the methods.";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: ''class'' is a keyword used to make a class.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: ''abstract'' is a keyword used to define a abstract class.";
        }

    }
}
