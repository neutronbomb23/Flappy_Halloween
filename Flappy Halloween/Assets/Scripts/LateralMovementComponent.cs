using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateralMovementComponent : MonoBehaviour
{
    #region parameters
    /// <summary>
    /// Movement speed for the obstacle
    /// </summary>
    [SerializeField]
    private float _speed;
    #endregion
    #region references
    /// <summary>
    /// Reference to own transform
    /// </summary>
    private Transform _myTransform;
    /// <summary>
    /// Reference to Game Manager
    /// </summary>
    private GameManager _gameManager;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = transform;
        _gameManager = GetComponent<GameManager>();
    } 
    // Update is called once per frame
    void Update()
    {
        _myTransform.position -= new Vector3(_speed, 0) * Time.deltaTime; 

    }

}
