using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   //Variables de manejo
    public float speed = 5.0f;
    public float turnSpeed = 0.0f;
    public float horizontalInput;
    public float forwardInput;

    //Variables de camara
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    //Variables multijugador
    public string inputID;

    

    void Start()
    {
        
    }
    void Update()
    {
        //Asignacion de configuraciones teclado
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        
        //Movilidad de vehiculo
        transform.Translate( Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //Cambio entre camaras
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !mainCamera.enabled;
        }

    }
}
