using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Codigo utilizado que al entrar en contacto el jugador con el objeto correspondiente, mandara al jugador a la pantalla de fin de juego, significando que lo a finalizado 
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("PantallaFinal");
        }
    }
}
