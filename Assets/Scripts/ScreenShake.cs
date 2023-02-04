using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScreenShake : MonoBehaviour
{

    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float duration = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Debug.Log("Shake");
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        
        Vector3 startPosition = transform.position;
        float elapsedTime = 0.0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;
        }

        //transform.position = startPosition;

    }
    
}
