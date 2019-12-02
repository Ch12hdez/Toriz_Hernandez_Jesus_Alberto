﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Si al colisionar al player con un objeto que tenga el Tag Puerta0 entonces me cargara la escena que lleve por nombre Nivel1. 
        if (other.gameObject.tag == "Puerta0")
        {
            SceneManager.LoadScene("Nivel1");
        }
    }
}
