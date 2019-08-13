using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalLevel : MonoBehaviour
{

        public void PlayGame()
        {
        //Codigo utilizado para que al ser activado por el jugador, lo transporte a la escena correspondiente (Normal)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        

    }