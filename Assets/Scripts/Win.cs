using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Ending1()
    {
        
    }

    void Ending2()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            Debug.Log("Player 1 win");
            Ending1();
        }
        if (other.tag == "Player2")
        {
            Debug.Log("Player 2 win");
            Ending2();
        }
    }
}
