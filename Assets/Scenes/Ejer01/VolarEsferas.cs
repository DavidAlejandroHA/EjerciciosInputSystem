using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VolarEsferas : MonoBehaviour
{
    public bool modoVolar;
    public PlayerInput playerInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (modoVolar)
        {
            playerInput.SwitchCurrentActionMap("Jetpack");
        }
        else
        {
            playerInput.SwitchCurrentActionMap("Player");
        }
        
    }
}
