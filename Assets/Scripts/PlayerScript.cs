using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector2 _movement;
    private Rigidbody2D _Player_Body;
    private int _player_index;
    private _Player _currentPlayer;
    private float _Attenuation = 10.0f / 5.0f;

    private Vector2 _addforce;
        //InputActionMap _ip;

    enum _Player
    {
        PLAYERONE,
        PLAYERTWO
    }
    
    private void Awake()
    {
        _Player_Body = GetComponent<Rigidbody2D>();
        _player_index++;
        if (_player_index <= 1)
        {
            _currentPlayer = _Player.PLAYERTWO;
        }
        _currentPlayer = _Player.PLAYERONE;
        _addforce.x = 0.0f;
        _addforce.y = -1.0f;
    }

    private void FixedUpdate()
    {
        
        _Player_Body.AddForce(_movement * _speed / _Attenuation);
        _Player_Body.velocity = _addforce;
       
        //TODO add moove split in two direction
    }

    public void OnMove(InputValue value)
    {
        _movement = value.Get<Vector2>();
        for (int i = 0; i < 2; i++)
        {
            var _interpolation = _Player_Body.interpolation;
            _Player_Body.interpolation = _interpolation;
        }
        switch (_currentPlayer)
        {
            case _Player.PLAYERONE:
                //InputSystem.FindControl("Move");
                //_ip.FindAction("WASD");
                break;
            case _Player.PLAYERTWO:
                //InputSystem.FindControls("Move");
                //_ip.FindAction("MoveTwo");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
