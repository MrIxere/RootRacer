using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConstructor : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private GameObject prefab3;

    void Start()
    {
        float BlocY = 0.0f;
        for (int i = 0; i < 6; i++)
        {
            int rand = Random.Range(0, 3);
            if (rand == 0)
            {
                Instantiate(prefab1, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 1)
            {
                Instantiate(prefab2, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 2)
            {
                Instantiate(prefab3, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            BlocY -= 85.79f;
            Debug.Log(rand);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

