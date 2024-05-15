using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SlowSnow : MonoBehaviour
{
    public GameObject player;
    public Tilemap snow;
    public PlayerMovement playerMovement;
    Vector3Int vector3Int;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        vector3Int = Vector3Int.FloorToInt(playerPos);
        if (snow.GetSprite(vector3Int).name == "Snow Path Tileset_9")
        {
            playerMovement.speed = 1.5f;
        }
        else
        {
            playerMovement.speed = 2.5f;
        }
    }
}
