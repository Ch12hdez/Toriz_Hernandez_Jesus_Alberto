using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

        public void PlayGame()
        {
        //Codigo encargado de al ser activado, mandar al jugador al menu de seleccion de dificultad y poder comenzar el juego en su nivel correspondiente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void QuitGame()
        {
        //Codigo encargado de al ser activado sacar al jugador del juego
            Debug.Log("QUIT!");
            Application.Quit();
        }

    }