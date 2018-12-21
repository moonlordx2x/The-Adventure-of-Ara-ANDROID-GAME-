using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint_close_tutorial : MonoBehaviour {

    public GameObject hint_1;
    public GameObject hint_2;


    public void close_ui()
    {
        hint_1.SetActive(false);
        hint_2.SetActive(false);
        Time.timeScale = 1f;
    }
}
