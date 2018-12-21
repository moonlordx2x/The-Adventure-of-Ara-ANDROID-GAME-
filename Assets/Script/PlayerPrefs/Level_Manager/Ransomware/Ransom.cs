using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ransom : MonoBehaviour {

	
	
	
	void Update () {

        if (PlayerPrefs.GetString("ransomware_quest") == "Completed")
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }


	}
}
