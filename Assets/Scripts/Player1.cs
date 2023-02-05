using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random=UnityEngine.Random;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject trailPrefab;
    [SerializeField] private GameObject spikePrefab1;
    [SerializeField] private GameObject spikePrefab2;
    [SerializeField] private GameObject spikePrefab3;
    [SerializeField] private GameObject spikePrefab4;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject stun;
    [SerializeField] private GameObject bonus;
    float timeForTrail = 0.0f;
    private float timeForStun = 0.0f;
    private bool isStuned = false;

    private bool spikeMoment = false;

    private float speed = 3.2f;

    private int rand;

    private Vector3 stunDirection;
    void Start()
    {
        
    }

    void FixedUpdate()
    {

        rand = Random.Range(0, 3);
        if (rand == 1)
        {
            spikeMoment = true;
        }
        if (Input.GetKey(KeyCode.E)|| Input.GetKey(KeyCode.D))
        {
            {
                transform.Rotate(0.0f,0.0f,1.25f);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.z >= -89)
            {
                transform.Rotate(0.0f,0.0f,-1.25f);
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
            if (spikeMoment == true)
            {
                int rand = Random.Range(0, 4);
                if (rand == 0)
                {
                    Instantiate(spikePrefab1, spawnPoint.transform.position, transform.rotation);
                }
                if (rand == 1)
                {
                    Instantiate(spikePrefab2, spawnPoint.transform.position, transform.rotation);
                }
                if (rand == 2)
                {
                    Instantiate(spikePrefab3, spawnPoint.transform.position, transform.rotation);
                }
                if (rand == 3)
                {
                    Instantiate(spikePrefab4, spawnPoint.transform.position, transform.rotation);
                }
                spikeMoment = false;
            }
            else
            {
                Instantiate(trailPrefab, spawnPoint.transform.position, transform.rotation);
            }
            
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
