using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject _textPlayerOneWin;

    private float _duration = 1.5f;
    
    private float _elapsedTime = 0.0f;
    // Start is called before the first frame update
    private void Awake()
    {
        _textPlayerOneWin.SetActive(false);
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
}
