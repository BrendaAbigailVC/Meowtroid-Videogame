/*using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChestController : MonoBehaviour
{
    Animator myAnim;
    public GameObject questionPanel;
    public TextMeshPro questionText;
    public Button[] answerButtons;
    public GameObject key;
    public List<Question> questions; // Define una lista de preguntas y respuestas
    private Question currentQuestion;
    private bool isOpen = false;

    private void Start()
    {
        myAnim = GetComponent<Animator>();
        questionPanel.SetActive(false);
        questions = new List<Question>
        {
            new Question
            {
                questionText = "¿Cuánto es 2 + 2?",
                answerOptions = new string[] { "3", "4", "5", "6" },
                correctAnswerIndex = 1
            },
            new Question
            {
                questionText = "¿Cuál es la raíz cuadrada de 9?",
                answerOptions = new string[] { "2", "3", "4", "5" },
                correctAnswerIndex = 1
            },
            new Question
            {
                questionText = "¿Cuánto es 8 * 7?",
                answerOptions = new string[] { "49", "56", "64", "72" },
                correctAnswerIndex = 1
            }
        };
    }

   private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E) && !isOpen) // Cambio de chestOpened a isOpen
            {
               OpenChest();
            }
        }
    }

    private void OpenChest()
    {
        myAnim.Play("chest_open");
        isOpen = true;
        // Mostrar la pregunta y respuestas
        currentQuestion = GetRandomQuestion();
        questionText.text = currentQuestion.questionText;

        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = currentQuestion.answerOptions[i];
            int index = i; // Captura la variable para usarla en el listener del botón
            answerButtons[i].onClick.AddListener(() => CheckAnswer(index));
        }
        questionPanel.SetActive(true);
    }

    private Question GetRandomQuestion()
    {
        int randomIndex = Random.Range(0, questions.Count);
        return questions[randomIndex];
    }

    private void CheckAnswer(int answerIndex)
    {
        if (currentQuestion.correctAnswerIndex == answerIndex)
        {
            // Respuesta correcta, otorgar la llave
            key.SetActive(true);
        }

        questionPanel.SetActive(false);
    }
}
*/