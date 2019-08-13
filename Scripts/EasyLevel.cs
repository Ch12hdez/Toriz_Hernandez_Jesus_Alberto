
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EasyLevel : MonoBehaviour
{

        public void PlayGame()
        {
        //Codigo utilizado para que al ser activado por el jugador, lo transporte a la escena correspondiente del nivel seleccionado en este caso al nivel Easy
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
    }