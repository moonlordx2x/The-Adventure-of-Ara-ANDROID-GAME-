using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint_2 : MonoBehaviour {

    public GameObject hint_box_ui;

    void OnMouseDown()
    {
        hint_box_ui.SetActive(true);
        Time.timeScale = 0f;
    }
}
