using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{

    [SerializeField] private int numberOfMonsters;
    [SerializeField] private Transform monsterSpawnPoint;
    [SerializeField] private GameObject[] monsterPrefabs;

    public List<GameObject> monsters;
    
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < numberOfMonsters; i++)
        {
            int monsterIndex = Random.Range(0, monsterPrefabs.Length);
            GameObject monster = Instantiate(monsterPrefabs[monsterIndex], monsterSpawnPoint.position, monsterSpawnPoint.rotation);
            monsters.Add(monster);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}