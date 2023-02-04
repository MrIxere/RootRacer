using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] private GameObject lava;
    void OnBecameVisible() {
        Instantiate(lava);
    }
}
