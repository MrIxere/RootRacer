using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 Movement;
    [SerializeField] private Rigidbody2D Playerbody;
    private const float Speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Playerbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Movement.x = Input.GetAxis("Horizontal");
        Movement.y = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       Playerbody.MovePosition(Playerbody.position + Movement * Speed);
    }
}
