using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Normal : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Codigo utilizado para cambiar de una escena a otra. 
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Normal");
        }
    }
}
