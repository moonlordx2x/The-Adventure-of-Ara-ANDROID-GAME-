using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour {

    public GameObject quit_notification;

	void Start () {
        quit_notification.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void quit_btn()
    {
        quit_notification.SetActive(true);
    }

    public void quit_btn_cancel()
    {
        quit_notification.SetActive(false);
    }
}
