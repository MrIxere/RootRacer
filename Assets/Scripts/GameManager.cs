using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public bool player1Win = false;
    public bool player2Win = false;
    private bool gameEnded = false;
    [SerializeField] private Camera camera;
    [SerializeField] private RawImage whiteScreen;
    
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
                gameEnded = true;
                Debug.Log("Player 1 win");
                StartCoroutine(Shake());
                StartCoroutine(WinPlayer1());
            }
        }

        if (gameEnded == false)
        {
            if (player2Win == true)
            {
                gameEnded = true;
                Debug.Log("Player 2 win");
                StartCoroutine(Shake());
                StartCoroutine(WinPlayer2());
            }
        }
    }

    IEnumerator WinPlayer1()
    {
        yield return new WaitForSeconds(screenShakeDuration);
        SceneManager.LoadScene("WinPlayerOne");
    }
    
    IEnumerator WinPlayer2()
    {
        yield return new WaitForSeconds(screenShakeDuration);
        SceneManager.LoadScene("WinPlayerTwo");
    }

    IEnumerator Shake()
    {
        float elapsedTime = 0.0f;
        while (elapsedTime < screenShakeDuration)
        {
            elapsedTime += Time.deltaTime;
            float strength = screenShakeCurve.Evaluate(elapsedTime / screenShakeDuration);
            camera.transform.position +=  Random.insideUnitSphere * strength;
            whiteScreen.color =  new Color(1.0f, 1.0f, 1.0f, elapsedTime -2 );
            yield return null;
        }
    }
}
