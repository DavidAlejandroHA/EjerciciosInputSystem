using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;

public class CamaraTouch : MonoBehaviour
{
    public PlayerInput playerInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*
        TouchState leido = playerInput.actions["Toque"].ReadValue<TouchState>();
        Ray raycast = Camera.main.ScreenPointToRay(leido.position);
        RaycastHit hit;

        if (Physics.Raycast(raycast, out hit, 100f))
        {
            Destroy(hit.transform.gameObject);
        }
        */
    }

    public void comprobarToque(InputAction.CallbackContext context)
    {
        TouchState leido = context.ReadValue<TouchState>();
        Ray raycast = Camera.main.ScreenPointToRay(leido.position);
        RaycastHit hit;

        if (Physics.Raycast(raycast, out hit, 100f))
        {
            Destroy(hit.transform.gameObject);
        }
    }
}
