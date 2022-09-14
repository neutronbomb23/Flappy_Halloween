using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputComponent : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {

        //Movement detection
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("Se ha pulsado la tecla espaciadora.");

        }

    }
}