using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using static System.Numerics.Vector2;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float cameraSpeed = 1.0f;
    [SerializeField] float cameraStop = 1.0f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(0, 9 - (Time.time * cameraSpeed), -10);
        if (transform.position.y <= cameraStop)
        {
            transform.position = new Vector3(0, cameraStop, -10);
            //SoundManager.PlaySound(SoundManager.Sound.Music);
        }
    }
}
