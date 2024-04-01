using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ejer03 : MonoBehaviour
{

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Jump(InputAction.CallbackContext callbackContext) {

        GetComponent<Renderer>().material.color = cambiarColor(callbackContext.phase);
       
    }

    public Color cambiarColor(InputActionPhase fase)
    {
        if (fase == InputActionPhase.Canceled) return Color.red;
        else if (fase == InputActionPhase.Started) return Color.yellow;
        else if (fase == InputActionPhase.Performed) return Color.green;
        else return Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
