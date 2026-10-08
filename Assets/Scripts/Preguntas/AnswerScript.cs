using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
     

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
            quizManager.DesactivarPanel();
            quizManager.AbrirCofre();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.correct();
            // Puedes agregar lógica adicional para manejar respuestas incorrectas aquí si es necesario.
        }
    }
}