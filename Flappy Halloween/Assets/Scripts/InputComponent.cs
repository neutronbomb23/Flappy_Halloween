using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputComponent : MonoBehaviour
{ 
    void Update()
    {
        //Movement detection
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Se ha pulsado la tecla espaciadora.");
            //GameManager.Instance.Jump(); // CAMBIAR
            SendMessage("Jump",8.0f);
        }
    }
}