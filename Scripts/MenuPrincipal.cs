using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void PlayGame()
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
        //Este codigo hace que al presionar el boton, me cargue el nivel que este a -5 de la escena final
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    public void PlayGame3()
    {
        //Este codigo hace que al presionar el boton, me cargue el nivel que este a +4 de la escena final
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
    }

    public void PlayGame4()
    {
        //Al presionar el boton se dirigira hacia la escena siguiente que es la numero 2. ya que el menu es el 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlayGame5()
    {
        //Al presionar el boton se dirigira hacia la escena siguiente que es la numero 3. ya que el menu es el 2
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
