using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputComponent : MonoBehaviour
{ 
    private MovementComponent _myMovementComponent;
    // Update is called once per frame

    void Start() {
       _myMovementComponent = GetComponent<MovementComponent>();
    }
    void Update()
    {

        //Movement detection
        if (Input.GetKeyDown(KeyCode.Space))
        {

            _myMovementComponent.Jump();
            Debug.Log("Se ha pulsado la tecla espaciadora.");

        }

    }
}