using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_answer : MonoBehaviour {

    public string answer;
    public GameObject success;

    Tutorial_answer_checker answer_result;

    // Use this for initialization
    void Start () {
        answer_result = GameObject.Find("Question_counter").GetComponent<Tutorial_answer_checker>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void first_quiz()
    {
        Debug.Log(answer);

        if (answer == "true")
        {
            Debug.Log("Correct");
            success.SetActive(true);
         
            answer_result.correct_answer_count += 1;
            answer_result.Question_1_var = "Correct";
        }
        else
        {
            success.SetActive(false);
            Debug.Log("Wrong");
            answer_result.wrong_answer_count += 1;
            answer_result.Question_1_var = "Wrong";
        }
    }
}
