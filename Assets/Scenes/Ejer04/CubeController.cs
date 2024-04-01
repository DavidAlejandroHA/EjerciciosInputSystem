using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class CubeController : MonoBehaviour
{
    public PlayerInput input { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * Time.deltaTime);
    }

    public void Touch(InputAction.CallbackContext context)
    {
       // TODO: Gestionar el toque con el cubo.
       // Hay que lanzar un rayo en base a la posición.
        
    }
}
