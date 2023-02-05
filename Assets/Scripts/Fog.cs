using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    [SerializeField] private GameObject fogLeft;
    [SerializeField] private GameObject fogRight;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        {
            fogLeft.transform.position += Vector3.left * Time.fixedDeltaTime;
            fogRight.transform.position += Vector3.right * Time.fixedDeltaTime;
        }
    }
}
