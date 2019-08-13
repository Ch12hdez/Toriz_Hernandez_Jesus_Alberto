using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardLevel : MonoBehaviour
{

        public void PlayGame()
        {
        //Codigo utilizado para que al ser activado por el jugador, lo transporte a la escena correspondiente (Hard)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }



}