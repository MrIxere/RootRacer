using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using static System.Numerics.Vector2;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float originalCameraSpeed = 2.5f;
    [SerializeField] float cameraSpeed = 3.0f;
    [SerializeField] float cameraStop = 1.0f;

    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        //SoundManager.PlaySound(SoundManager.Sound.Music);
        transform.position = new Vector3(0.0f, 9.0f, -10.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += -Vector3.up  * Time.fixedDeltaTime * cameraSpeed;
        
        if (player1.transform.position.y < transform.position.y - 2)
        {
            cameraSpeed = cameraSpeed + 0.005f;
        }

        if (player2.transform.position.y < transform.position.y - 2)
        {
            cameraSpeed = cameraSpeed + 0.005f;
        }
        if (player1.transform.position.y  > transform.position.y - 2)
        {
            if (player2.transform.position.y > transform.position.y - 2)
            {
                cameraSpeed = cameraSpeed - 0.005f;
                if (cameraSpeed < originalCameraSpeed)
                {
                    cameraSpeed = originalCameraSpeed;
                }
            }
        }
        
        
        
        
        if (transform.position.y <= cameraStop)
        {
            transform.position = new Vector3(0, cameraStop, -10);
        }
    }
}
