using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameController_cplus : MonoBehaviour {

    public GameObject player_1;

    private Vector3 playerlocation_1;

    public float smooth;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        // Defautl Outfit

        playerlocation_1 = new Vector3(player_1.transform.position.x, transform.position.y, transform.position.z);

        if (player_1.transform.localScale.x > 0f)
        {
            playerlocation_1 = new Vector3(playerlocation_1.x + offset, playerlocation_1.y, playerlocation_1.z);

        }
        else if ((player_1.transform.localScale.x < 0f))
        {
            playerlocation_1 = new Vector3(playerlocation_1.x - offset, playerlocation_1.y, playerlocation_1.z);

        }
        transform.position = Vector3.Lerp(transform.position, playerlocation_1, smooth * Time.deltaTime);

        // Cplus Outfit

    }
}
