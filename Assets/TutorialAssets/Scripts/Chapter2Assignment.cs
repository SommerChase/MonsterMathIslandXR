using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Chapter2Assignment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> randomNumbers = new List<int>(10);
        
        // Capacity is different than Count. 
        for (int index = 0; index < randomNumbers.Capacity; index++)
        {
            int randomInt = Random.Range(1, 100);
            randomNumbers.Add(randomInt);
            
            Debug.Log(randomNumbers[index]);
        }
        
        Debug.Log($"Here's the list before: {string.Join(", ", randomNumbers)}.");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
