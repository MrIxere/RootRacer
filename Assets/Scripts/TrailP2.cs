using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailP2 : MonoBehaviour
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
            if (Input.GetKey(KeyCode.RightArrow))
            {
                {
                    transform.Rotate(0.0f,0.0f,0.1f);
                }
                
            }
            
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.rotation.z >= -89)
                {
                    transform.Rotate(0.0f,0.0f,-0.1f);
                }
            }
    
            transform.position += -transform.up / 190.0f;
    
            if (time >= 0.1f)
            {
                Instantiate(trailPrefab, spawnPoint.transform.position, transform.rotation);
                time = 0;
            }
            time += Time.deltaTime;
        }
}
