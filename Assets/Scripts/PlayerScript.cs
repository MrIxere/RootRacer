using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    private Vector2 _movement;
    private Rigidbody2D _Player_Body;

    private void Awake()
    {
        _Player_Body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _Player_Body.AddForce(_movement * _speed);
    }

    public void OnMove(InputValue value)
    {
        _movement = value.Get<Vector2>();
    }
}
