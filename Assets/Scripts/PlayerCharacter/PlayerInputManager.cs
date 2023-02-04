using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] private Array _player_array;
    // Start is called before the first frame update
    private void Awake()
    {
        if (_player_array == _player_array.GetValue(0))
        {
            
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputValue value)
    {
        value.Get<Vector2>();
    }
}
