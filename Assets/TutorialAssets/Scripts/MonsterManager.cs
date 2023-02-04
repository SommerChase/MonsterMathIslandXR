using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{

    [SerializeField] private Transform monsterSpawnPoint;
    [SerializeField] private GameObject[] monsterPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            int monsterIndex = Random.Range(0, monsterPrefabs.Length);
            Instantiate(monsterPrefabs[monsterIndex], monsterSpawnPoint.position, monsterSpawnPoint.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
