using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
 #region parameters
    [SerializeField]
    private float _jumpForce;   
    #endregion

    #region references
    private Rigidbody2D _myRigidBody2D; //Position.
    #endregion

    #region methods
    public void Jump(){
        _myRigidBody2D.velocity = Vector2.up * _jumpForce;
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _myRigidBody2D = GetComponent<Rigidbody2D>();
    }
}
