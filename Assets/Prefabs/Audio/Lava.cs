using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] private GameObject lava;
    [SerializeField] private GameObject dig;
    void OnBecameVisible() {
        Instantiate(lava);
        Destroy(dig);
    }
}
