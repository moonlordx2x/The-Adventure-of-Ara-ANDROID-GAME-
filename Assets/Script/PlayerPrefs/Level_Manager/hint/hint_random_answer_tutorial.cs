using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint_random_answer_tutorial : MonoBehaviour
{

    public Text hint_1;
    public Text hint_2;

    void Update()
    {
        hint_1.text = "FACT: Binary (or base 2) a numeric system that only uses two digits - 0 and 1. Computers operate in binary, meaning they store data and perform calculations using only zeros and ones.";
        hint_2.text = "FACT: Binary (or base 2) a numeric system that only uses two digits - 0 and 1. Computers operate in binary, meaning they store data and perform calculations using only zeros and ones.";
    }

}
