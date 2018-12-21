using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crafting : MonoBehaviour {


    public GameObject reward_active_1;
    public GameObject reward_deactive_1;

    public GameObject reward_active_2;
    public GameObject reward_deactive_2;

    public GameObject reward_active_3;
    public GameObject reward_deactive_3;

    public GameObject craft_active;
    public GameObject craft_deactive;
    public GameObject craft_completed;

    public GameObject rwd_txt_active_1;
    public GameObject rwd_txt_deactive_1;

    public GameObject rwd_txt_active_2;
    public GameObject rwd_txt_deactive_2;

    public GameObject rwd_txt_active_3;
    public GameObject rwd_txt_deactive_3;


    void Update () {
        
        switch (this.name)
        {

            case "Cplus_Craft":

                if (PlayerPrefs.GetString("quest_cplus_1") == "Incompleted")
                {
                    reward_active_1.SetActive(false);
                    reward_deactive_1.SetActive(true);
                    rwd_txt_active_1.SetActive(false);
                    rwd_txt_deactive_1.SetActive(true);
                }
                else
                {
                    reward_active_1.SetActive(true);
                    reward_deactive_1.SetActive(false);
                    rwd_txt_active_1.SetActive(true);
                    rwd_txt_deactive_1.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_cplus_2") == "Incompleted")
                {
                    reward_active_2.SetActive(false);
                    reward_deactive_2.SetActive(true);
                    rwd_txt_active_2.SetActive(false);
                    rwd_txt_deactive_2.SetActive(true);
                }
                else
                {
                    reward_active_2.SetActive(true);
                    reward_deactive_2.SetActive(false);
                    rwd_txt_active_2.SetActive(true);
                    rwd_txt_deactive_2.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_cplus_3") == "Incompleted")
                {
                    reward_active_3.SetActive(false);
                    reward_deactive_3.SetActive(true);
                    rwd_txt_active_3.SetActive(false);
                    rwd_txt_deactive_3.SetActive(true);
                }
                else
                {
                    reward_active_3.SetActive(true);
                    reward_deactive_3.SetActive(false);
                    rwd_txt_active_3.SetActive(true);
                    rwd_txt_deactive_3.SetActive(false);
                }


                if (PlayerPrefs.GetString("quest_cplus_3") == "Completed" && PlayerPrefs.GetString("quest_cplus_2") == "Completed" && PlayerPrefs.GetString("quest_cplus_1") == "Completed" && PlayerPrefs.GetInt("Pl_coin") >= 500)
                {
                    craft_active.SetActive(true);
                    craft_deactive.SetActive(false);
                }
                else
                {
                    craft_active.SetActive(false);
                    craft_deactive.SetActive(true);
                }

                if (PlayerPrefs.GetString("crafting_reward_cplus") == "Completed")
                {
                    craft_completed.SetActive(true);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_cplus"));
                }
                else
                {
                    craft_completed.SetActive(false);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_cplus"));
                }

                break;

            case "Cplus_Craft_1920_Up":

                if (PlayerPrefs.GetString("quest_cplus_1") == "Incompleted")
                {
                    reward_active_1.SetActive(false);
                    reward_deactive_1.SetActive(true);
                    rwd_txt_active_1.SetActive(false);
                    rwd_txt_deactive_1.SetActive(true);
                }
                else
                {
                    reward_active_1.SetActive(true);
                    reward_deactive_1.SetActive(false);
                    rwd_txt_active_1.SetActive(true);
                    rwd_txt_deactive_1.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_cplus_2") == "Incompleted")
                {
                    reward_active_2.SetActive(false);
                    reward_deactive_2.SetActive(true);
                    rwd_txt_active_2.SetActive(false);
                    rwd_txt_deactive_2.SetActive(true);
                }
                else
                {
                    reward_active_2.SetActive(true);
                    reward_deactive_2.SetActive(false);
                    rwd_txt_active_2.SetActive(true);
                    rwd_txt_deactive_2.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_cplus_3") == "Incompleted")
                {
                    reward_active_3.SetActive(false);
                    reward_deactive_3.SetActive(true);
                    rwd_txt_active_3.SetActive(false);
                    rwd_txt_deactive_3.SetActive(true);
                }
                else
                {
                    reward_active_3.SetActive(true);
                    reward_deactive_3.SetActive(false);
                    rwd_txt_active_3.SetActive(true);
                    rwd_txt_deactive_3.SetActive(false);
                }


                if (PlayerPrefs.GetString("quest_cplus_3") == "Completed" && PlayerPrefs.GetString("quest_cplus_2") == "Completed" && PlayerPrefs.GetString("quest_cplus_1") == "Completed" && PlayerPrefs.GetInt("Pl_coin") >= 500)
                {
                    craft_active.SetActive(true);
                    craft_deactive.SetActive(false);
                    craft_completed.SetActive(false);
                }
                else
                {
                    
                    craft_active.SetActive(false);
                    craft_deactive.SetActive(true);
                    craft_completed.SetActive(false);
                }

                if (PlayerPrefs.GetString("crafting_reward_cplus") == "Completed")
                {
                    craft_completed.SetActive(true);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_cplus"));
                }
                else
                {
                    craft_completed.SetActive(false);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_cplus"));
                }

                break;

            case "Java_Craft":

                if (PlayerPrefs.GetString("quest_java_1") == "Incompleted")
                {
                    reward_active_1.SetActive(false);
                    reward_deactive_1.SetActive(true);
                    rwd_txt_active_1.SetActive(false);
                    rwd_txt_deactive_1.SetActive(true);
                }
                else
                {
                    reward_active_1.SetActive(true);
                    reward_deactive_1.SetActive(false);
                    rwd_txt_active_1.SetActive(true);
                    rwd_txt_deactive_1.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_java_2") == "Incompleted")
                {
                    reward_active_2.SetActive(false);
                    reward_deactive_2.SetActive(true);
                    rwd_txt_active_2.SetActive(false);
                    rwd_txt_deactive_2.SetActive(true);
                }
                else
                {
                    reward_active_2.SetActive(true);
                    reward_deactive_2.SetActive(false);
                    rwd_txt_active_2.SetActive(true);
                    rwd_txt_deactive_2.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_java_3") == "Incompleted")
                {
                    reward_active_3.SetActive(false);
                    reward_deactive_3.SetActive(true);
                    rwd_txt_active_3.SetActive(false);
                    rwd_txt_deactive_3.SetActive(true);
                }
                else
                {
                    reward_active_3.SetActive(true);
                    reward_deactive_3.SetActive(false);
                    rwd_txt_active_3.SetActive(true);
                    rwd_txt_deactive_3.SetActive(false);
                }


                if (PlayerPrefs.GetString("quest_java_3") == "Completed" && PlayerPrefs.GetString("quest_java_2") == "Completed" && PlayerPrefs.GetString("quest_java_1") == "Completed" && PlayerPrefs.GetInt("Pl_coin") >= 600)
                {
                    craft_active.SetActive(true);
                    craft_deactive.SetActive(false);
                }
                else
                {
                    
                    craft_active.SetActive(false);
                    craft_deactive.SetActive(true);
                }

                if (PlayerPrefs.GetString("crafting_reward_java") == "Completed")
                {
                    craft_completed.SetActive(true);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_java"));
                }
                else
                {
                    craft_completed.SetActive(false);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_java"));
                }

                break;

            case "Java_Craft_1920_Up":

                if (PlayerPrefs.GetString("quest_java_1") == "Incompleted")
                {
                    reward_active_1.SetActive(false);
                    reward_deactive_1.SetActive(true);
                    rwd_txt_active_1.SetActive(false);
                    rwd_txt_deactive_1.SetActive(true);
                }
                else
                {
                    reward_active_1.SetActive(true);
                    reward_deactive_1.SetActive(false);
                    rwd_txt_active_1.SetActive(true);
                    rwd_txt_deactive_1.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_java_2") == "Incompleted")
                {
                    reward_active_2.SetActive(false);
                    reward_deactive_2.SetActive(true);
                    rwd_txt_active_2.SetActive(false);
                    rwd_txt_deactive_2.SetActive(true);
                }
                else
                {
                    reward_active_2.SetActive(true);
                    reward_deactive_2.SetActive(false);
                    rwd_txt_active_2.SetActive(true);
                    rwd_txt_deactive_2.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_java_3") == "Incompleted")
                {
                    reward_active_3.SetActive(false);
                    reward_deactive_3.SetActive(true);
                    rwd_txt_active_3.SetActive(false);
                    rwd_txt_deactive_3.SetActive(true);
                }
                else
                {
                    reward_active_3.SetActive(true);
                    reward_deactive_3.SetActive(false);
                    rwd_txt_active_3.SetActive(true);
                    rwd_txt_deactive_3.SetActive(false);
                }


                if (PlayerPrefs.GetString("quest_java_3") == "Completed" && PlayerPrefs.GetString("quest_java_2") == "Completed" && PlayerPrefs.GetString("quest_java_1") == "Completed" && PlayerPrefs.GetInt("Pl_coin") >= 600)
                {
                    craft_active.SetActive(true);
                    craft_deactive.SetActive(false);
                }
                else
                {
                    
                    craft_active.SetActive(false);
                    craft_deactive.SetActive(true);
                }

                if (PlayerPrefs.GetString("crafting_reward_java") == "Completed")
                {
                    craft_completed.SetActive(true);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_java"));
                }
                else
                {
                    craft_completed.SetActive(false);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_java"));
                }

                break;

            case "Php_Craft":

                if (PlayerPrefs.GetString("quest_php_1") == "Incompleted")
                {
                    reward_active_1.SetActive(false);
                    reward_deactive_1.SetActive(true);
                    rwd_txt_active_1.SetActive(false);
                    rwd_txt_deactive_1.SetActive(true);
                }
                else
                {
                    reward_active_1.SetActive(true);
                    reward_deactive_1.SetActive(false);
                    rwd_txt_active_1.SetActive(true);
                    rwd_txt_deactive_1.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_php_2") == "Incompleted")
                {
                    reward_active_2.SetActive(false);
                    reward_deactive_2.SetActive(true);
                    rwd_txt_active_2.SetActive(false);
                    rwd_txt_deactive_2.SetActive(true);
                }
                else
                {
                    reward_active_2.SetActive(true);
                    reward_deactive_2.SetActive(false);
                    rwd_txt_active_2.SetActive(true);
                    rwd_txt_deactive_2.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_php_3") == "Incompleted")
                {
                    reward_active_3.SetActive(false);
                    reward_deactive_3.SetActive(true);
                    rwd_txt_active_3.SetActive(false);
                    rwd_txt_deactive_3.SetActive(true);
                }
                else
                {
                    reward_active_3.SetActive(true);
                    reward_deactive_3.SetActive(false);
                    rwd_txt_active_3.SetActive(true);
                    rwd_txt_deactive_3.SetActive(false);
                }


                if (PlayerPrefs.GetString("quest_php_3") == "Completed" && PlayerPrefs.GetString("quest_php_2") == "Completed" && PlayerPrefs.GetString("quest_php_1") == "Completed" && PlayerPrefs.GetInt("Pl_coin") >= 700)
                {
                    craft_active.SetActive(true);
                    craft_deactive.SetActive(false);
                }
                else
                {
                   
                    craft_active.SetActive(false);
                    craft_deactive.SetActive(true);
                }

                if (PlayerPrefs.GetString("crafting_reward_php") == "Completed")
                {
                    craft_completed.SetActive(true);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_php"));
                }
                else
                {
                    craft_completed.SetActive(false);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_php"));
                }

                break;

            case "Php_Craft_1920_Up":

                if (PlayerPrefs.GetString("quest_php_1") == "Incompleted")
                {
                    reward_active_1.SetActive(false);
                    reward_deactive_1.SetActive(true);
                    rwd_txt_active_1.SetActive(false);
                    rwd_txt_deactive_1.SetActive(true);
                }
                else
                {
                    reward_active_1.SetActive(true);
                    reward_deactive_1.SetActive(false);
                    rwd_txt_active_1.SetActive(true);
                    rwd_txt_deactive_1.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_php_2") == "Incompleted")
                {
                    reward_active_2.SetActive(false);
                    reward_deactive_2.SetActive(true);
                    rwd_txt_active_2.SetActive(false);
                    rwd_txt_deactive_2.SetActive(true);
                }
                else
                {
                    reward_active_2.SetActive(true);
                    reward_deactive_2.SetActive(false);
                    rwd_txt_active_2.SetActive(true);
                    rwd_txt_deactive_2.SetActive(false);
                }

                if (PlayerPrefs.GetString("quest_php_3") == "Incompleted")
                {
                    reward_active_3.SetActive(false);
                    reward_deactive_3.SetActive(true);
                    rwd_txt_active_3.SetActive(false);
                    rwd_txt_deactive_3.SetActive(true);
                }
                else
                {
                    reward_active_3.SetActive(true);
                    reward_deactive_3.SetActive(false);
                    rwd_txt_active_3.SetActive(true);
                    rwd_txt_deactive_3.SetActive(false);
                }


                if (PlayerPrefs.GetString("quest_php_3") == "Completed" && PlayerPrefs.GetString("quest_php_2") == "Completed" && PlayerPrefs.GetString("quest_php_1") == "Completed" && PlayerPrefs.GetInt("Pl_coin") >= 700)
                {
                    craft_active.SetActive(true);
                    craft_deactive.SetActive(false);
                }
                else
                {

                    craft_active.SetActive(false);
                    craft_deactive.SetActive(true);
                }

                if (PlayerPrefs.GetString("crafting_reward_php") == "Completed")
                {
                    craft_completed.SetActive(true);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_php"));
                }
                else
                {
                    craft_completed.SetActive(false);
                    Debug.Log(PlayerPrefs.GetString("crafting_reward_php"));
                }

                break;


        }


        
        Debug.Log(PlayerPrefs.GetString("C++ "+"quest_cplus_1"));
        Debug.Log(PlayerPrefs.GetString("C++ " + "quest_cplus_2"));
        Debug.Log(PlayerPrefs.GetString("C++ " + "quest_cplus_3"));

        Debug.Log(PlayerPrefs.GetString("JAVA " + "quest_java_1"));
        Debug.Log(PlayerPrefs.GetString("JAVA " + "quest_java_2"));
        Debug.Log(PlayerPrefs.GetString("JAVA " + "quest_java_3"));

        Debug.Log(PlayerPrefs.GetString("PHP " + "quest_php_1"));
        Debug.Log(PlayerPrefs.GetString("PHP " + "quest_php_2"));
        Debug.Log(PlayerPrefs.GetString("PHP " + "quest_php_3"));

    }


}
