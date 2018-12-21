using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_hint : MonoBehaviour {

    public bool trigger_hint;

    public GameObject hint;

    void Start () {
        hint.SetActive(false);

    }
	
	
	void Update () {

        if (trigger_hint == true)
        {
            hint.SetActive(true);
        }
        else
        {
            hint.SetActive(false);
        }
	}
}
