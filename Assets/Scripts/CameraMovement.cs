using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using static System.Numerics.Vector2;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float cameraSpeed;
    [SerializeField] Rigidbody2D cam;
    public float cameraMove = 0.0f;
    public Transform up;
    public Transform down;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0 - Time.time, -10);
    }
}
