using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passthrough : MonoBehaviour
{
    public GameObject obstacle;

    public GameObject player;
    void Update()
    {
        if (player.transform.position.y >= obstacle.transform.position.y)
        {
            player.GetComponent<SpriteRenderer>().sortingLayerName = "PlayerBottom";
        }
        else 
        {
            player.GetComponent<SpriteRenderer>().sortingLayerName = "PlayerTop";
        }
    }
}
