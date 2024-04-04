using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class Ejer02 : MonoBehaviour
{
    public CinemachineVirtualCamera cam1;
    public CinemachineVirtualCamera cam2;
    Rigidbody rb;
    PlayerInput playerInput;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 leido = playerInput.actions["Moverse"].ReadValue<Vector2>();
        // leido.x -> GetAxis("Horizontal);
        // leido.y -> GetAxis("Vertical);
        rb.velocity = new Vector3(leido.x, rb.velocity.y, leido.y) * velocidad;
    }

    public void Saltar()
    {
        //Debug.Log("Saltando " + context);
        rb.AddForce(Vector3.up, ForceMode.Impulse);
        Debug.Log("a");
    }

    public void cambiarCamara()
    {
        int prioritycam2 = cam2.Priority;
        cam2.Priority = cam1.Priority;
        cam1.Priority = prioritycam2;
    }
}
