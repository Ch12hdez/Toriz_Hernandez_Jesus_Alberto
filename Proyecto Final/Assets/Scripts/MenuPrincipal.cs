using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void PlayGame ()
    {
        //Al presionar el boton se dirigira hacia la escena siguiente que es la numero 1. ya que el menu es el 0
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //Al presionar el boton quitara automaticamente el juego
        Debug.Log("Quit");
        Application.Quit();
    }

    public void PlayGame2()
    {
        //Este codigo hace que al presionar el boton, me cargue el nivel que este a -4 de la escena final
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }


}
