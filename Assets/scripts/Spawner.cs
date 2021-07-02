using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private Creature EnemyPrefab;
    [SerializeField] private int count; 
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i<count;i++)
        {
            Instantiate(EnemyPrefab);
        }
    }

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(EnemyPrefab);
        }
    }
}
