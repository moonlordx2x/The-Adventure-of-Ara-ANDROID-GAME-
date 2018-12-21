using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cplus_answer_checker : MonoBehaviour {


    public int correct_answer_count;
    public int wrong_answer_count;

    public GameObject success;
    //public GameObject failed;

    int coin;
    public int coin_reward;
    public int coin_reward_finish;


    public Text Question_1;
    public Text Question_2;
    public Text Question_3;
    public Text Question_4;
    public Text Question_5;

    public Text Total_Correct;
    public Text Total_Mistake;
    public Text Total_Coin;
    public Text Quest_Result;
    public Text Quest_Name;
    public Text Next_Stage_World;

    public string Question_1_var;
    public string Question_2_var;
    public string Question_3_var;
    public string Question_4_var;
    public string Question_5_var;

    public bool quest_active;
    public bool quest_active_2;
    public bool quest_active_3;

    public string Quest_Result_var;
    public string Quest_Name_var;
    public string Next_Stage_World_name;

    void Start()
    {
        coin = PlayerPrefs.GetInt("Pl_coin");
        success.SetActive(false);
        //failed.SetActive(false);

    }

    void Update () {

        Debug.Log("Quest_Active_1 " + quest_active);
        Debug.Log("Quest_Active_2 " + quest_active_2);
        Debug.Log("Quest_Active_3 " + quest_active_3);

        if (correct_answer_count == 5)
        {
            if (quest_active == true || quest_active_2 == true || quest_active_3 == true)
            {
                Next_Stage_World.text = "Success C++ Stage Clear";

                Quest_Result_var = "Quest Completed";
                success.SetActive(true);
                coin_reward = coin_reward_finish;
                PlayerPrefs.SetInt("Pl_coin", coin + coin_reward);
                PlayerPrefs.Save();
            }

            else
            {
                Next_Stage_World.text = "Success" + Next_Stage_World_name + " Unlock";

                Quest_Result_var = "Quest Completed";
                success.SetActive(true);
                PlayerPrefs.SetInt("Pl_coin", coin + coin_reward);
                PlayerPrefs.Save();

            }

            if (Next_Stage_World_name == "C++ World 2" && Quest_Name_var == "C++ World 1 Quest")
            {
                cplus_world_1();
                Debug.Log("Success Stage 1");
            }

            else if (Next_Stage_World_name == "C++ World 3" && Quest_Name_var == "C++ World 2 Quest")
            {
                cplus_world_2();
                Debug.Log("Success Stage 2");
            }

            else if (Next_Stage_World_name == "Java World 1" && Quest_Name_var == "C++ World 3 Quest")
            {
                cplus_world_3();
                Debug.Log("Success Stage 3");
            }


        }
        else if (correct_answer_count == 4 && wrong_answer_count == 1)
        {

            if (quest_active == true || quest_active_2 == true || quest_active_3 == true)
            {
                Next_Stage_World.text = "Success C++ Stage Clear";

                Quest_Result_var = "Quest Completed";
                success.SetActive(true);
                coin_reward = coin_reward_finish;
                PlayerPrefs.SetInt("Pl_coin", coin + coin_reward);
                PlayerPrefs.Save();
            }

            else
            {
                Next_Stage_World.text = "Success " + Next_Stage_World_name + " Unlock";

                Quest_Result_var = "Quest Completed";
                success.SetActive(true);

                PlayerPrefs.SetInt("Pl_coin", coin + coin_reward);
                PlayerPrefs.Save();

            }

            if (Next_Stage_World_name == "C++ World 2" && Quest_Name_var == "C++ World 1 Quest")
            {
                cplus_world_1();
                Debug.Log("Success Stage 1");
            }

            else if (Next_Stage_World_name == "C++ World 3" && Quest_Name_var == "C++ World 2 Quest")
            {
                cplus_world_2();
                Debug.Log("Success Stage 2");
            }

            else if (Next_Stage_World_name == "Java World 1" && Quest_Name_var == "C++ World 3 Quest")
            {
                cplus_world_3();
                Debug.Log("Success Stage 3");
            }

        }

        else if (wrong_answer_count == 2)
        {
            Next_Stage_World.text = "GAME OVER";
            coin_reward = 0;
            Quest_Result_var = "Quest Failed";
            success.SetActive(true);
        }
        Debug.Log(correct_answer_count);
        Debug.Log(wrong_answer_count);
        Debug.Log(coin_reward);

        if (Question_1_var == "Correct" || Question_1_var == "Wrong") Question_1.text = "Question 1 :"+Question_1_var;
        else Question_1.text = "Question 1 : unfinished";

        if (Question_2_var == "Correct" || Question_2_var == "Wrong") Question_2.text = "Question 2 :" + Question_2_var;
        else Question_2.text = "Question 2 : unfinished";

        if (Question_3_var == "Correct" || Question_3_var == "Wrong") Question_3.text = "Question 3 :" + Question_3_var;
        else Question_3.text = "Question 3 : unfinished";

        if (Question_4_var == "Correct" || Question_4_var == "Wrong") Question_4.text = "Question 4 :" + Question_4_var;
        else Question_4.text = "Question 4 : unfinished";

        if (Question_5_var == "Correct" || Question_5_var == "Wrong") Question_5.text = "Question 5 :" + Question_5_var;
        else Question_5.text = "Question 5 : unfinished";

        Total_Correct.text = "Total Correct :" + correct_answer_count;
        Total_Mistake.text = "Total Mistake :" + wrong_answer_count;
        Total_Coin.text = "Total PL Coins :" + coin_reward;
        Quest_Result.text = Quest_Result_var;
        Quest_Name.text = Quest_Name_var;


    }

    void cplus_world_1()
    {
        PlayerPrefs.SetString("quest_cplus_1", "Completed");
        PlayerPrefs.SetString("cplus_2", "Active");
        PlayerPrefs.SetString("tutorial_2", "Active");
        PlayerPrefs.Save();

        Debug.Log("Save 1");
    }

    void cplus_world_2()
    {
        PlayerPrefs.SetString("quest_cplus_2", "Completed");
        PlayerPrefs.SetString("cplus_3", "Active");
        PlayerPrefs.Save();

        Debug.Log("Save 2");
    }

    void cplus_world_3()
    {
        PlayerPrefs.SetString("quest_cplus_3", "Completed");
        PlayerPrefs.SetString("java_1", "Active");
        PlayerPrefs.SetString("java", "Active");
        PlayerPrefs.Save();

        Debug.Log("Save 3");
    }
}
