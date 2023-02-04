using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject _textPlayerOneWin;

    private float _durateTime = 13.0f;
    // Start is called before the first frame update
    private void Awake()
    {
        _textPlayerOneWin.SetActive(false);
    }

    void Update()
    {
        var _elapsedTime = 0.0f;
        while (_elapsedTime < _durateTime)
        {
            _elapsedTime += Time.deltaTime;
            if (!(_elapsedTime <= _durateTime)) continue;
            _textPlayerOneWin.SetActive(true);
            break;
        }
    }
}
