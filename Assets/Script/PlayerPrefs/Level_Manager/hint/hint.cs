using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint : MonoBehaviour {

    public GameObject hint_box_ui;

    void OnMouseDown()
    {
        hint_box_ui.SetActive(true);
        Time.timeScale = 0f;
    }

    public void deub()
    {
        Debug.Log("hello world");
    }

}
