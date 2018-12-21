using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_php : MonoBehaviour {
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
            hint_1.text = "FACT: PHP previously stood for Personal Home Page now stands for Hypertext Preprocessor.";
        }

        else if (range_1.random_set_1 == 2)
        {
            hint_1.text = "FACT: PHP files have a default file extension of ''.php''";
        }

        else if (range_1.random_set_1 == 3)
        {
            hint_1.text = "FACT: A PHP script should start with <?php and end with ?>.";
        }


        /*      HINT MESSAGE 2          */

        if (range_1.random_set_2 == 4)
        {
            hint_2.text = "Fact: Sublime text editor is a sample of code/text editor for web development like php.";
        }

        else if (range_1.random_set_2 == 5)
        {
            hint_2.text = "FACT: To run PHP code you need to have PHP and a web server, both IIS and Apache are web servers.You can choose either one according to your platform.";
        }

        else if (range_1.random_set_2 == 6)
        {
            hint_2.text = "FACT: PHP Version 5 added support for Exception Handling.";
        }


        /*      HINT MESSAGE 3          */

        if (range_1.random_set_3 == 7)
        {
            hint_3.text = "FACT: /* */ can also be use to comment just a single line although it is used for paragraphs. // and # are used only for single line comment.";
        }

        else if (range_1.random_set_3 == 8)
        {
            hint_3.text = "FACT: Sample to declare a variable in php:  $sample = 'sample';";
        }

        else if (range_1.random_set_3 == 9)
        {
            hint_3.text = "FACT: .(dot) is used to combine two parts of the statement.";
        }


        /*      HINT MESSAGE 4          */

        if (range_1.random_set_4 == 10)
        {
            hint_4.text = "FACT: A variable can’t start with a number. Also $this is a special variable that can’t be assigned, but $This can be assigned.";
        }

        else if (range_1.random_set_4 == 11)
        {
            hint_4.text = "FACT: echo and print Statements. echo and print are more or less the same. They are both used to output data to the screen.";
        }

        else if (range_1.random_set_4 == 12)
        {
            hint_4.text = "Fact: echo(), print() and printf() all three can be used to output a statement onto the screen.";
        }


        /*      HINT MESSAGE 5          */

        if (range_1.random_set_5 == 13)
        {
            hint_5.text = "FACT: double quotation('''') will read variables in php while single quotation('') will read only strings.";
        }

        else if (range_1.random_set_5 == 14)
        {
            hint_5.text = "FACT: PHP also called as Personal Home Page.";
        }

        else if (range_1.random_set_5 == 15)
        {
            hint_5.text = "FACT: $var = $var + $var; can be shorten to $var+=$var;.";
        }

    }
}
