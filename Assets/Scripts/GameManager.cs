using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public bool player1Win = false;
    public bool player2Win = false;
    private bool gameEnded = false;
    [SerializeField] private Camera camera;
    
    // ScreenShake
    [SerializeField] private AnimationCurve screenShakeCurve;
    [SerializeField] private float screenShakeDuration = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.position = new Vector3(0.0f, 10.0f, -10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded == false)
        {
            if (player1Win == true)
            {
                Debug.Log("Player 1 win");
                StartCoroutine(Shake());
                gameEnded = true;
            }
        }

        if (gameEnded == false)
        {
            if (player2Win == true)
            {
                Debug.Log("Player 2 win");
                StartCoroutine(Shake());
                gameEnded = true;
            }
        }
    }
    
    IEnumerator Shake()
    {
        
        //Vector3 startPosition = transform.position;
        float elapsedTime = 0.0f;
        while (elapsedTime < screenShakeDuration)
        {
            elapsedTime += Time.deltaTime;
            float strength = screenShakeCurve.Evaluate(elapsedTime / screenShakeDuration);
            camera.transform.position +=  Random.insideUnitSphere * strength;
            yield return null;
        }

    }
}
