using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public float camSens = 0.50f; // How sensitive is the mouse

    private Vector3 lastMouse = new Vector3(255, 255, 255);

    [SerializeField]
    public GameObject bullet;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CameraMovement();
	}

    // Mueve la camara con el raton
    void CameraMovement()
    {
        // 
        lastMouse = Input.mousePosition - lastMouse;

        // Cambiado el orden del parametro porque se tiene en cuenta el eje sobre el que se rota
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);

        // 
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);

        // Le asigna a la camara los angulos calculados
        transform.eulerAngles = lastMouse;

        // Guarda la posicion actual para compararla luego
        lastMouse = Input.mousePosition;
    }


    // Invoca la bala y dispara
    void Shoot()
    {

    }
}
