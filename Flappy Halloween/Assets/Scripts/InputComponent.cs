using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputComponent : MonoBehaviour
{ 
    void Update()
    {
        //Movement detection
        if (Input.GetKeyDown(KeyCode.Space)){
            SendMessage("Jump",8.0f);
            Debug.Log("Se ha pulsado la tecla espaciadora.");
        }
    }
}