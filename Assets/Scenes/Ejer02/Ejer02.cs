using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ejer02 : MonoBehaviour
{
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
}
