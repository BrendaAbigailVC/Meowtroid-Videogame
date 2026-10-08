using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion; 
    public Text QuestionTxt;
    public bool bandera = false;
    public GameObject questionUI;
    public CofreController cofre;

    public void Start()
    {
        GenerateQuestion();
    }

    public void correct() 
    {
        if (currentQuestion >= 0 && currentQuestion < QnA.Count) {    
            QnA.RemoveAt(currentQuestion);
            GenerateQuestion();
        } else {
            Debug.LogWarning("No hay más preguntas disponibles.");
        }
    }

    public void DesactivarPanel(){
        if (questionUI != null){
            questionUI.SetActive(false);
        }
    } 

    public void AbrirCofre(){
        cofre.OpenChest();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
           
            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
                
            }
        }
    }

    void GenerateQuestion() 
    {
        if (QnA.Count > 0) {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        } else {
            Debug.LogWarning("No hay más preguntas disponibles.");
        }
    }
}
