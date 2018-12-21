using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_controller_db : MonoBehaviour {

    public GameObject dashboard;
    GameObject player;

    void Start () {

        dashboard.SetActive(true);
       // player.SetActive(true);
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void quest_menu()
    {

        dashboard.SetActive(false);
        //player.SetActive(false);
       
    }

    public void dashboard_menu()
    {
        dashboard.SetActive(true);
        //player.SetActive(true);

    }
}
