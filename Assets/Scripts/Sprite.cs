using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Sprite : MonoBehaviour
{
    [SerializeField] UnityEngine.Sprite sprite1;
    [SerializeField] UnityEngine.Sprite sprite2;
    [SerializeField] UnityEngine.Sprite sprite3;
    [SerializeField] UnityEngine.Sprite sprite4;
    [SerializeField] UnityEngine.Sprite sprite5;
    //private SpriteRenderer renderer;
    private int rand;

    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        rand = Random.Range(0, 6);
        Debug.Log(rand);
        if (rand == 0)
        {
             spriteRenderer.sprite = sprite1;
        }
        if (rand == 1)
        {
             spriteRenderer.sprite = sprite2;
        }
        if (rand == 2)
        {
             spriteRenderer.sprite = sprite3;
        }
        if (rand == 3)
        {
             spriteRenderer.sprite = sprite4;
        }
        if (rand == 4)
        {
             spriteRenderer.sprite = sprite5;
        }
    }
}
