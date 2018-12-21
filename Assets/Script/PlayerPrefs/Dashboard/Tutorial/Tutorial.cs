using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public GameObject stage_1;
    public GameObject stage_2;
    public GameObject stage_3;
    public GameObject stage_4;

    void Start()
    {
        stage_1.SetActive(false);
        stage_2.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hello world");

            switch (this.name)
            {

                case "Stage_1":
                    stage_1.SetActive(true);
                    break;
                case "Stage_2":
                    stage_2.SetActive(true);
                    break;
                case "Stage_3":
                    stage_3.SetActive(true);
                    break;
                case "Stage_4":
                    stage_4.SetActive(true);
                    break;

                default:
                    stage_1.SetActive(false);
                    stage_2.SetActive(false);
                    stage_3.SetActive(false);
                    stage_4.SetActive(false);
                    break;


            }

        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hello world");

            switch (this.name)
            {

                case "Stage_1":
                    stage_1.SetActive(true);
                    break;
                case "Stage_2":
                    stage_2.SetActive(true);
                    break;
                case "Stage_3":
                    stage_3.SetActive(true);
                    break;
                case "Stage_4":
                    stage_4.SetActive(true);
                    break;

                default:
                    stage_1.SetActive(false);
                    stage_2.SetActive(false);
                    stage_3.SetActive(false);
                    stage_4.SetActive(false);
                    break;


            }

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        switch (this.name)
        {

            case "Stage_1":
                stage_1.SetActive(false);
                break;

            case "Stage_2":
                stage_2.SetActive(false);
                break;
            case "Stage_3":
                stage_3.SetActive(false);
                break;
            case "Stage_4":
                stage_4.SetActive(false);
                break;

            default:
                stage_1.SetActive(false);
                stage_2.SetActive(false);
                stage_3.SetActive(false);
                stage_4.SetActive(false);
                break;


        }


    }


}
