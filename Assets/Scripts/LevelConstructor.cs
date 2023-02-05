using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConstructor : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject prefab1_1;
    [SerializeField] private GameObject prefab1_2;
    [SerializeField] private GameObject prefab2_1;
    [SerializeField] private GameObject prefab2_2;

    [SerializeField] private GameObject prefab3_1;
    [SerializeField] private GameObject prefab3_2;
    [SerializeField] private GameObject prefab4_1;
    [SerializeField] private GameObject prefab4_2;

    private int firstPool = -1;
    private int secondPool = -1;
    private int thirdPool = -1;
    private int fourthPool = -1;
    

    void Start()
    {
        float BlocY = 0.0f;
        for (int i = 0; i < 4; i++)
        {
            int rand = Random.Range(0, 8);
            while (rand == firstPool)
            {
                rand = Random.Range(0, 8);
            }
            while (rand == secondPool)
            {
                rand = Random.Range(0, 8);
            }
            while (rand == thirdPool)
            {
                rand = Random.Range(0, 8);    
            }
            while (rand == fourthPool)
            {
                rand = Random.Range(0, 8);
            }
            
            

            if (rand == 0)
            {
                Instantiate(prefab1_1, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 1)
            {
                Instantiate(prefab1_2, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 2)
            {
                Instantiate(prefab2_1, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 3)
            {
                Instantiate(prefab2_2, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 4)
            {
                Instantiate(prefab3_1, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 5)
            {
                Instantiate(prefab3_2, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 6)
            {
                Instantiate(prefab4_1, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            if (rand == 7)
            {
                Instantiate(prefab4_2, new Vector3(0, (-38.21f + BlocY), 0), Quaternion.identity);
            }
            
            
            if (i == 0)
            {
                firstPool = rand;
            }
            if (i == 1)
            {
                secondPool = rand;
            }
            if (i == 2)
            {
                thirdPool = rand;
            }
            if (i == 3)
            {
                fourthPool = rand;
            }
            
            
            BlocY -= 85.79f;
            Debug.Log(rand);
        }
    }
}

