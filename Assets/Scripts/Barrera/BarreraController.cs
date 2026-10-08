using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreraController : MonoBehaviour
{
    public GameObject barrera; // Referencia al objeto de la barrera
    public GameObject player; // Referencia al jugador
    public CofreController cofreController; // Referencia al script del cofre

    void Start()
    {
        barrera.SetActive(true); // Asegura que la barrera esté activada al inicio.
    }

    void Update()
    {
        // Comprueba si el jugador ha obtenido la llave del cofre
        if (!cofreController.keyPicked)
        {
            barrera.SetActive(true); // Activa la barrera si la llave aún no se ha obtenido
        }
        else
        {
            barrera.SetActive(false); // Desactiva la barrera si se ha obtenido la llave
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && !cofreController.keyPicked)
        {
            // Impide el paso del jugador si no se ha obtenido la llave
            player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
