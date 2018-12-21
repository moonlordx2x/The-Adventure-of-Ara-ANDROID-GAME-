using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progess_check : MonoBehaviour {

    public Image progress_bar;
    public static float player_progress_position;

    void Start()
    {
        player_progress_position = 0;
        progress_bar.fillAmount = 0;
    }

    void Update()
    {
        progress_bar.fillAmount = player_progress_position;
    }
}
