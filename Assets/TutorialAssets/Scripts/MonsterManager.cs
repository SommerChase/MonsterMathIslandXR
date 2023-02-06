using System.Collections;
using System.Collections.Generic;
using TutorialAssets.Scripts;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{

    [SerializeField] private int numberOfMonsters;
    [SerializeField] private Transform monsterSpawnPoint;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private Transform queuePoint;
    [SerializeField] private GameObject[] monsterPrefabs;
    [SerializeField] private float waveDifficulty;

    public List<GameObject> monsters;
    
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < numberOfMonsters; i++)
        {
            InstantiateMonster();
        }
        
        MonsterAttacks(0);

        CalculateWaveDifficulty(ref waveDifficulty);

    }

    private void InstantiateMonster()
    {
        int monsterIndex = Random.Range(0, monsterPrefabs.Length);
        GameObject monster =
            Instantiate(monsterPrefabs[monsterIndex], monsterSpawnPoint.position, monsterSpawnPoint.rotation);
        monsters.Add(monster);
    }

    public void MonsterAttacks(int monsterIndex)
    {

        if (monsters.Count <= monsterIndex) return;

        Transform monster = monsters[monsterIndex].transform;
        monster.GetComponent<MonsterController>().ChangeState(MonsterState.Attack);
        monster.position = attackPoint.position;
        monster.rotation = attackPoint.rotation;

    }

    float CalculateWaveDifficulty(ref float difficulty)
    {
        foreach (GameObject monster in monsters)
        {
            difficulty += monster.GetComponent<Points>().points;
        }

        difficulty /= (numberOfMonsters * 3);

        return difficulty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}