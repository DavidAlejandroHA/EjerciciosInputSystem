using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ejer01 : MonoBehaviour
{

    Rigidbody rb;
    PlayerInput playerInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }

   // TODO: HACER LAS ACCIONES PARA SALTAR Y PARA MOVERSE

    public void Saltar(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //Debug.Log("Saltando " + context);
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }

    /*public void Moverse(InputAction.CallbackContext context)
    {
        Vector2 vectorLeido = context.action.ReadValue<Vector2>();
        rb.velocity = vectorLeido;
    }*/

    // Update is called once per frame
    void Update()
    {
        Vector2 leido = playerInput.actions["Moverse"].ReadValue<Vector2>();
        // leido.x -> GetAxis("Horizontal);
        // leido.y -> GetAxis("Vertical);
        rb.velocity = new Vector3(leido.x, rb.velocity.y, leido.y);
    }
}
