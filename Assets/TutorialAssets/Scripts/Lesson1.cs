using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        int number1 = Random.Range(1, 1000);
        int number2 = Random.Range(1, 1000);
        
        Debug.Log($"Number 1: {number1} and Number 2: {number2}");

        // Suboptimal
        if (number1 > number2)
        {
            Debug.Log($"Number 1 is higher ya nerd");
        }
        else
        {
            Debug.Log($"Numba 2 is the best!");
        }
        
        // Optimal
        Debug.Log(number1 > number2 ? "1 is higher" : "2 is higher");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
