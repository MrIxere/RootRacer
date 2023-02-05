using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject trailPrefab;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject stun;
    [SerializeField] private GameObject bonus;
    float timeForTrail = 0.0f;
    private float timeForStun = 0.0f;
    private bool isStuned = false;

    private float speed = 3.2f;

    private Vector3 stunDirection;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            {
                transform.Rotate(0.0f,0.0f,1f);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.rotation.z >= -89)
            {
                transform.Rotate(0.0f,0.0f,-1f);
            }
        }
        
       
        if (isStuned == true)
        {
            transform.position += stunDirection * Time.fixedDeltaTime * 3.2f;
            if (timeForStun >= 0.5f)
            {
                isStuned = false;
                timeForStun = 0.0f;
            }
            timeForStun += Time.deltaTime;
        }
        else
        {
            transform.position += -transform.up * Time.fixedDeltaTime * speed;
        }

        if (timeForTrail >= 0.01f)
        {
            Instantiate(trailPrefab, spawnPoint.transform.position, transform.rotation);
            timeForTrail = 0;
        }
        timeForTrail += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle")
        {
            isStuned = true;
            stunDirection = transform.up;
            Instantiate(stun);
        }
        if (other.tag == "Booster")
        {
            Destroy(other.gameObject);
            speed += 0.1f;
            Instantiate(bonus);
        }
    }
}
