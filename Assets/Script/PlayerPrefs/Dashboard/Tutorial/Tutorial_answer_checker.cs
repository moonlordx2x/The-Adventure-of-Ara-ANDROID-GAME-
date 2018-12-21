using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_answer_checker : MonoBehaviour {

    public int correct_answer_count;
    public int wrong_answer_count;

    public GameObject success;

    int coin;
    public int coin_reward;


    public Text Question_1;


    public Text Total_Correct;
    public Text Total_Mistake;
    public Text Total_Coin;
    public Text Quest_Result;
    public Text Quest_Name;
    public Text Next_Stage_World;

    public string Question_1_var;


    public bool quest_active;
    public bool quest_active_2;
    public bool quest_active_3;

    public string Quest_Result_var;
    public string Quest_Name_var;
    public string Next_Stage_World_name;

    public GameObject button_success;
    public GameObject button_wrong;


    void Start () {
		
	}

    void Update()
    {

        if (correct_answer_count == 1)
        {

                Next_Stage_World.text = "Success" + Next_Stage_World_name + " Unlock";

                Quest_Result_var = "Quest Completed";
                success.SetActive(true);
                PlayerPrefs.SetInt("Pl_coin", coin + coin_reward);
                PlayerPrefs.Save();


                cplus_world_1();
                button_success.SetActive(true);
                button_wrong.SetActive(false);

        }


        else if (wrong_answer_count == 1)
        {
            Next_Stage_World.text = "GAME OVER";
            coin_reward = 0;
            Quest_Result_var = "Quest Failed";
            success.SetActive(true);

            button_success.SetActive(false);
            button_wrong.SetActive(true);
        }

        Debug.Log(correct_answer_count);
        Debug.Log(wrong_answer_count);
        Debug.Log(coin_reward);

        if (Question_1_var == "Correct" || Question_1_var == "Wrong") Question_1.text = "Question 1 :" + Question_1_var;
        else Question_1.text = "Question 1 : unfinished";

        Total_Correct.text = "Total Correct :" + correct_answer_count;
        Total_Mistake.text = "Total Mistake :" + wrong_answer_count;
        Total_Coin.text = "Total PL Coins :" + coin_reward;
        Quest_Result.text = Quest_Result_var;
        Quest_Name.text = Quest_Name_var;


    }

    void cplus_world_1()
    {
        PlayerPrefs.SetString("crafting_reward_binary", "Completed");
        PlayerPrefs.SetString("tutorial", "Active");
        PlayerPrefs.Save();

        Debug.Log(PlayerPrefs.GetString("tutorial"));
    }

}

