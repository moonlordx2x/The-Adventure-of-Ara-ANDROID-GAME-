using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cplus_quiz_2 : MonoBehaviour {
    public string answer;
    public GameObject next_stage;
    public GameObject try_stage;

    Canvas quiz_number_1;
    Canvas quiz_number_2;
    Canvas quiz_number_3;
    Canvas quiz_number_4;
    Canvas quiz_number_5;
    Canvas quiz_number_6;
    Canvas quiz_number_7;
    Canvas quiz_number_8;
    Canvas quiz_number_9;
    Canvas quiz_number_10;
    Canvas quiz_number_11;
    Canvas quiz_number_12;
    Canvas quiz_number_13;
    Canvas quiz_number_14;
    Canvas quiz_number_15;

    Cplus_answer_checker answer_result;

    void Start()
    {
        answer_result = GameObject.Find("Question_counter").GetComponent<Cplus_answer_checker>();

        if (PlayerPrefs.GetString("quest_cplus_2") == "Completed")
        {
            answer_result.quest_active_2 = true;
        }
        else
        {
            answer_result.quest_active_2 = false;
        }
    }


    // Set 1

    public void first_quiz()
    {
        Debug.Log(answer);

        if (answer == "B")
        {
            Debug.Log("Correct");
            quiz_number_1 = GameObject.Find("first_question").GetComponent<Canvas>();
            quiz_number_1.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");

            answer_result.correct_answer_count += 1;
            answer_result.Question_1_var = "Correct";
        }
        else
        {
            quiz_number_1 = GameObject.Find("first_question").GetComponent<Canvas>();
            quiz_number_1.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_1_var = "Wrong";
        }
    }

    public void second_quiz()
    {
        Debug.Log(answer);

        if (answer == "D")
        {
            Debug.Log("Correct");
            quiz_number_2 = GameObject.Find("second_question").GetComponent<Canvas>();
            quiz_number_2.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_1_var = "Correct";
        }
        else
        {
            quiz_number_2 = GameObject.Find("second_question").GetComponent<Canvas>();
            quiz_number_2.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_1_var = "Wrong";
        }
    }

    public void third_quiz()
    {
        Debug.Log(answer);

        if (answer == "D")
        {
            Debug.Log("Correct");
            quiz_number_3 = GameObject.Find("third_question").GetComponent<Canvas>();
            quiz_number_3.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_1_var = "Correct";
        }
        else
        {
            quiz_number_3 = GameObject.Find("third_question").GetComponent<Canvas>();
            quiz_number_3.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_1_var = "Wrong";
        }
    }


    // Set 2

    public void fourth_quiz()
    {
        Debug.Log(answer);

        if (answer == "C")
        {
            Debug.Log("Correct");
            quiz_number_4 = GameObject.Find("fourth_question").GetComponent<Canvas>();
            quiz_number_4.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_2_var = "Correct";
        }
        else
        {
            quiz_number_4 = GameObject.Find("fourth_question").GetComponent<Canvas>();
            quiz_number_4.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_2_var = "Wrong";
        }
    }

    public void fifth_quiz()
    {
        Debug.Log(answer);

        if (answer == "A")
        {
            Debug.Log("Correct");
            quiz_number_5 = GameObject.Find("fifth_question").GetComponent<Canvas>();
            quiz_number_5.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_2_var = "Correct";
        }
        else
        {
            //try_stage.SetActive(true);
            quiz_number_5 = GameObject.Find("fifth_question").GetComponent<Canvas>();
            quiz_number_5.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_2_var = "Wrong";
        }
    }

    public void six_quiz()
    {
        Debug.Log(answer);

        if (answer == "C")
        {
            Debug.Log("Correct");
            quiz_number_6 = GameObject.Find("six_question").GetComponent<Canvas>();
            quiz_number_6.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_2_var = "Correct";
        }
        else
        {
            quiz_number_6 = GameObject.Find("six_question").GetComponent<Canvas>();
            quiz_number_6.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_2_var = "Wrong";
        }
    }

    // Set 3


    public void seven_quiz()
    {
        Debug.Log(answer);

        if (answer == "A")
        {
            Debug.Log("Correct");
            quiz_number_7 = GameObject.Find("seven_question").GetComponent<Canvas>();
            quiz_number_7.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_3_var = "Correct";
        }
        else
        {
            quiz_number_7 = GameObject.Find("seven_question").GetComponent<Canvas>();
            quiz_number_7.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_3_var = "Wrong";
        }
    }

    public void eight_quiz()
    {
        Debug.Log(answer);

        if (answer == "D")
        {
            Debug.Log("Correct");
            quiz_number_8 = GameObject.Find("eight_question").GetComponent<Canvas>();
            quiz_number_8.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_3_var = "Correct";
        }
        else
        {
            quiz_number_8 = GameObject.Find("eight_question").GetComponent<Canvas>();
            quiz_number_8.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_3_var = "Wrong";
        }
    }

    public void nineth_quiz()
    {
        Debug.Log(answer);

        if (answer == "B")
        {
            Debug.Log("Correct");
            quiz_number_9 = GameObject.Find("nineth_question").GetComponent<Canvas>();
            quiz_number_9.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_3_var = "Correct";
        }
        else
        {
            quiz_number_9 = GameObject.Find("nineth_question").GetComponent<Canvas>();
            quiz_number_9.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_3_var = "Wrong";
        }
    }

    // Set 4

    public void tenth_quiz()
    {
        Debug.Log(answer);

        if (answer == "C")
        {
            Debug.Log("Correct");
            quiz_number_10 = GameObject.Find("tenth_question").GetComponent<Canvas>();
            quiz_number_10.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_4_var = "Correct";
        }
        else
        {
            quiz_number_10 = GameObject.Find("tenth_question").GetComponent<Canvas>();
            quiz_number_10.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_4_var = "Wrong";
        }
    }

    public void eleven_quiz()
    {
        Debug.Log(answer);

        if (answer == "A")
        {
            Debug.Log("Correct");
            quiz_number_11 = GameObject.Find("eleventh_question").GetComponent<Canvas>();
            quiz_number_11.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_4_var = "Correct";
        }
        else
        {
            quiz_number_11 = GameObject.Find("eleventh_question").GetComponent<Canvas>();
            quiz_number_11.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_4_var = "Wrong";
        }
    }

    public void twelve_quiz()
    {
        Debug.Log(answer);

        if (answer == "C")
        {
            Debug.Log("Correct");
            quiz_number_12 = GameObject.Find("twelve_question").GetComponent<Canvas>();
            quiz_number_12.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_4_var = "Correct";
        }
        else
        {
            quiz_number_12 = GameObject.Find("twelve_question").GetComponent<Canvas>();
            quiz_number_12.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_4_var = "Wrong";
        }
    }

    // Set 5

    public void thirteen_quiz()
    {
        Debug.Log(answer);

        if (answer == "A")
        {
            Debug.Log("Correct");
            quiz_number_13 = GameObject.Find("thirteen_question").GetComponent<Canvas>();
            quiz_number_13.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_5_var = "Correct";
        }
        else
        {
            quiz_number_13 = GameObject.Find("thirteen_question").GetComponent<Canvas>();
            quiz_number_13.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_4_var = "Wrong";
        }
    }

    public void fourteen_quiz()
    {
        Debug.Log(answer);

        if (answer == "C")
        {
            Debug.Log("Correct");
            quiz_number_14 = GameObject.Find("fourteen_question").GetComponent<Canvas>();
            quiz_number_14.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_5_var = "Correct";
        }
        else
        {
            quiz_number_14 = GameObject.Find("fourteen_question").GetComponent<Canvas>();
            quiz_number_14.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_5_var = "Wrong";
        }
    }

    public void fifteen_quiz()
    {
        Debug.Log(answer);

        if (answer == "B")
        {
            Debug.Log("Correct");
            quiz_number_15 = GameObject.Find("fifteen_question").GetComponent<Canvas>();
            quiz_number_15.enabled = false;
            //PlayerPrefs.SetString("cplus_2", "active");
            answer_result.correct_answer_count += 1;
            answer_result.Question_5_var = "Correct";
        }
        else
        {
            quiz_number_15 = GameObject.Find("fifteen_question").GetComponent<Canvas>();
            quiz_number_15.enabled = false;
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_5_var = "Wrong";
        }
    }
}
