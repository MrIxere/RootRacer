using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinBox : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    //[SerializeField] private GameObject whiteScreen;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //whiteScreen.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
           gameManager.player1Win = true;

        }
        if (other.tag == "Player2")
        {
            gameManager.player2Win = true;
        }
    }
}