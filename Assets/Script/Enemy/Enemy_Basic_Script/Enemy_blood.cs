using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_blood : MonoBehaviour {

    public GameObject blood;

    Enemy_health Hp;

    void Start()
    {
        Hp = GetComponentInParent<Enemy_health>();    
    }

    void Update()
    {
        if (Hp.HP <=0)
        {
            Debug.Log("Hello world");
        }
    }


}
