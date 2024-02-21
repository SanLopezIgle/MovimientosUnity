using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Reference to the player GameObject.
    public GameObject player;

    // The distance between the camera and the player.
    private Vector3 offset;

    // Start is called before the first frame update.
    void Start()
    {
        // Calcula el desplazamiento incial de la camara desde la posicion del jugador
        offset = transform.position - player.transform.position;
        
        /*
        // Asegura que la cámara mire en la misma dirección que el jugador
        transform.rotation = player.transform.rotation;
        */
    }

    // LateUpdate is called once per frame after all Update functions have been completed.
    void LateUpdate()
    {
        // Mueve la cámara a la posición de los ojos del jugador
        transform.position = player.transform.position + offset;
        
        /*
        // Asegura que la cámara mire en la misma dirección que el jugador
        transform.rotation = player.transform.rotation;
        */
    }
}