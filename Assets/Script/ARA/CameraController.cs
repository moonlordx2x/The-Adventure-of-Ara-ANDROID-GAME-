using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    
    public GameObject player;

    private Vector3 playerlocation;

    public float smooth;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        // Defautl Outfit

        playerlocation = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

        if (player.transform.localScale.x > 0f)
        {      
            playerlocation = new Vector3(playerlocation.x + offset, playerlocation.y, playerlocation.z);
            
        }
        else if((player.transform.localScale.x < 0f))
        {
            playerlocation = new Vector3(playerlocation.x - offset, playerlocation.y, playerlocation.z);
           
        }

        transform.position = Vector3.Lerp(transform.position, playerlocation, smooth * Time.deltaTime);
       
        // Cplus Outfit

    }

  


}
