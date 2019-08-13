﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Codigo utilizado para que, cuando el jugador entre en contacto con el, automaticamente lo regrese al punto de inicio del nivel. 
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Nivel 1");
        }
    }
}
