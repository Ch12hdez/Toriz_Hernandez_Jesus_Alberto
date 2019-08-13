using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    private Transform myTransform;
    private Rigidbody cubeRigidBody;
    public float Velocidad;
    public float jumpHight = 100;

    // Start is called before the first frame update
    void Start()
    {
        //Codigo usado para activar los componentes que se le necesitan aplicar al player para que actue de manera correcta
        myTransform = GetComponent<Transform>();
        cubeRigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //Codigo utilizado para que el jugador al activar la tecla flecha arriba, se genere el movimiento superior marcado
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myTransform.Translate(new Vector3(0, 0, Velocidad) * Time.deltaTime);

        }

        //Codigo utilizado para que el jugador al activar la tecla flecha abajo, se genere el movimiento inferior marcado
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myTransform.Translate(new Vector3(0, 0, -Velocidad) * Time.deltaTime);

        }

        //Codigo utilizado para que el jugador al activar la tecla flecha izquierda, se genere el movimiento izquierdo marcado
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myTransform.Translate(new Vector3(-Velocidad, 0, 0) * Time.deltaTime);

        }

        //Codigo utilizado para que el jugador al activar la tecla flecha derecha, se genere el movimiento derecho marcado
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myTransform.Translate(new Vector3(Velocidad, 0, 0) * Time.deltaTime);

        }

    }
}
