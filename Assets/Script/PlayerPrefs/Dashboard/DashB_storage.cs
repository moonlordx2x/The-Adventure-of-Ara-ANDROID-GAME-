using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashB_storage : MonoBehaviour {

    
    public Text Coin;

    void Update () {
        
        Coin.text =PlayerPrefs.GetInt("Pl_coin").ToString() + " COINs";
    }
	

}
