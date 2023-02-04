using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Trail : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject trailPrefab;
    [SerializeField] private GameObject spawnPoint;
    float time = 0.0f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E)|| Input.GetKey(KeyCode.D))
        {
            {
                transform.Rotate(0.0f,0.0f,0.1f);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.z >= -89)
            {
                transform.Rotate(0.0f,0.0f,-0.1f);
            }
        }
        
        transform.position += -transform.up / 50;

        if (time >= 0.1f)
        {
            Instantiate(trailPrefab, spawnPoint.transform.position, transform.rotation);
            time = 0;
            
        }
        time += Time.deltaTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        OnBecameInvisible();
    }

    private void OnBecameInvisible()
    {
        DestroyImmediate(trailPrefab,this);
    }
}
