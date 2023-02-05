using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using static System.Numerics.Vector2;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float originalCameraSpeed = 2.0f;
    [SerializeField] float cameraSpeed = 3.0f;
    [SerializeField] float cameraStop = 1.0f;

    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    [SerializeField] private float speedChangingLimit = 0.0f;

    private bool startingCinematic = true;
    private float time = 0.0f;

    // Start is called before the first frame update
    void Start() //TODO also in game manager
    {
        transform.position = new Vector3(0.0f, 32.0f, -10.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        if (startingCinematic == true)
        {
            transform.position += -Vector3.up  * Time.fixedDeltaTime * cameraSpeed;
            if (time >= 6.0f)
            {
                startingCinematic = false;
            }
        }
        else
        {
            transform.position += -Vector3.up  * Time.fixedDeltaTime * cameraSpeed;
        
            if (player1.transform.position.y < transform.position.y - speedChangingLimit)
            {
                cameraSpeed = cameraSpeed + 0.05f;
            }

            if (player2.transform.position.y < transform.position.y - speedChangingLimit)
            {
                cameraSpeed = cameraSpeed + 0.05f;
            }
            if (player1.transform.position.y  > transform.position.y - speedChangingLimit + 1)
            {
                if (player2.transform.position.y > transform.position.y - speedChangingLimit + 1)
                {
                    cameraSpeed = cameraSpeed - 0.1f;
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
}
