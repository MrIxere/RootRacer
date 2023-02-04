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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
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

        transform.position += -transform.up / 300.0f;

        if (time >= 0.5f)
        {
            Instantiate(trailPrefab, spawnPoint.transform.position, transform.rotation);
            time = 0;
        }
        time += Time.deltaTime;
    }
}
