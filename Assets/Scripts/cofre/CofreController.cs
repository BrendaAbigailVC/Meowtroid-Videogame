using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CofreController : MonoBehaviour
{
    Animator myAnim;
    public GameObject key;
    bool chestOpened = false;
    public bool keyPicked = false;
    public int itemAmount;
    int itemCount;
    public GameObject questionUI; // Referencia a la interfaz de preguntas

    void Start()
    {
        myAnim = GetComponent<Animator>();
        questionUI.SetActive(false); // Asegura que la interfaz de preguntas esté desactivada al inicio.
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E) && !chestOpened && !keyPicked)
            {
                MostrarPreguntas();
            }
        }
    }

    void MostrarPreguntas(){
        if (questionUI.activeSelf) // Verifica si la interfaz de preguntas está activada
        {
            questionUI.SetActive(false); // Desactiva la interfaz
        }
        else
        {
            questionUI.SetActive(true); // Activa la interfaz
        }
    }
    
   public void OpenChest()
    {
        if (!keyPicked) // Verifica si la llave aún no ha sido recogida
        {
            myAnim.Play("chest_open");
            while (itemCount < itemAmount)
            {
                Instantiate(key, transform.position, Quaternion.identity);
                itemCount++;
            }
            // Mueve la siguiente línea para que keyPicked se active después de tomar el objeto
        }
        chestOpened = true;
        keyPicked = true; // Activa keyPicked después de tomar el objeto
    }

}