using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [NonSerialized] public float speed = 2.5f;
    private Rigidbody2D rigid;
    private Vector2 direction;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        canvas.isActiveAndEnabled.Equals(false);
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }
    
    void FixedUpdate()
    {
        rigid.velocity = direction * speed;
    }
}
