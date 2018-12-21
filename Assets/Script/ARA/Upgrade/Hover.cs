using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {

    public GameObject sample;
	
	void Start () {
        sample.SetActive(false);

    }


    public void sample_2()
    {
        sample.SetActive(true);
    }

    public void sample_3()
    {
        sample.SetActive(false);
    }
}
