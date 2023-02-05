using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject _textPlayerOneWin;

    [SerializeField] private RawImage whiteScreen;
    private float _duration = 1.5f;
    
    private float _elapsedTime = 0.0f;
    // Start is called before the first frame update
    private void Awake()
    {
        _textPlayerOneWin.SetActive(false);
        StartCoroutine(WhiteFade());
    }

    void Update()
    {
        while (_elapsedTime < _duration)
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= _duration)
            _textPlayerOneWin.SetActive(true);
            break;
        }
    }
    
    IEnumerator WhiteFade()
    {
        float fadeDuration = 1.0f;
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            whiteScreen.color =  new Color(1.0f, 1.0f, 1.0f, 1.0f -elapsedTime );
            yield return null;
        }
    }
}
