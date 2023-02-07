using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private MonsterManager _monsterManager;
    [SerializeField] private TMP_Text messageBoxTextField;
    [SerializeField] private TMP_InputField answerInputField;
    [SerializeField] private int answer;

    // Start is called before the first frame update
    void Start()
    {
        
        GenerateQuestion();

    }

    private void GenerateQuestion()
    {
        
        // Random numbers used for problem:
        var qa = GenerateAddSubtract(1, 100);

        messageBoxTextField.text = qa.question;
        
        ClearInputField();
        
    }

    private (string question, int answer) GenerateAddSubtract(int min, int max)
    {
        int operand1 = Random.Range(min, max);
        int operand2 = Random.Range(min, max);
        string question = "";

        if (Random.value < 0.5f)
        {
            question = $"{operand1} + {operand2} = ?";
            answer = operand1 + operand2;
        }
        else
        {
            question = $"{operand1} - {operand2} = ?";
            answer = operand1 - operand2;
            // hey
        }

        return (question, answer);
    }

    public void ValidateAnswer()
    {
        if (answerInputField.text == answer.ToString())
        {
            _monsterManager.KillMonster(0);
            _monsterManager.MonsterAttacks(0);
            _monsterManager.MoveNextMonsterToQueue();
            GenerateQuestion();
        }
        else
        {
            ClearInputField();
        }
    }

    private void ClearInputField()
    {
        answerInputField.text = "";
        answerInputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
