using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Crafting_2 : MonoBehaviour {

    public GameObject object_1;
    public GameObject object_2;

    public GameObject Tutorial_2;
    public GameObject Tutorial_3;

  
    public GameObject upgrade_locked;

    public GameObject map_locked;
    public GameObject map_unlocked;

    public GameObject back_locked;
    public GameObject back_unlocked;


    void Start () {
        object_1.SetActive(true);
        object_2.SetActive(false);
        map_locked.SetActive(true);
        map_unlocked.SetActive(false);

        map_locked.SetActive(true);
        map_unlocked.SetActive(false);

        back_unlocked.SetActive(true);
        back_locked.SetActive(true);
    }
	
	public void minus()
    {
        object_1.SetActive(true);
        object_2.SetActive(false);
        Tutorial_2.SetActive(true);
        Tutorial_3.SetActive(false);

        map_locked.SetActive(true);
        map_unlocked.SetActive(false);

        back_locked.SetActive(true);
    }

    public void plus()
    {
        object_1.SetActive(false);
        object_2.SetActive(true);
        Tutorial_2.SetActive(false);
        Tutorial_3.SetActive(true);
        
        upgrade_locked.SetActive(true);
        map_locked.SetActive(false);
        map_unlocked.SetActive(true);

        
        back_locked.SetActive(false);
        
    }

}
