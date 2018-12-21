using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint_close : MonoBehaviour {

    public GameObject hint_1;
    public GameObject hint_2;
    public GameObject hint_3;
    public GameObject hint_4;
    public GameObject hint_5;



    public void close_ui()
    {
        hint_1.SetActive(false);
        hint_2.SetActive(false);
        hint_3.SetActive(false);
        hint_4.SetActive(false);
        hint_5.SetActive(false);
        Time.timeScale = 1f;
    }
}
