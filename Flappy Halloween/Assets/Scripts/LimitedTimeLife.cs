using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedTimeLife : MonoBehaviour
{
    #region paramaters
    /// <summary>
    /// Maximum time before the script destroys the object
    /// </summary>
    [SerializeField]
    private float _maxLifetime;

    private float _elapsedTime; // Chrono to destroy gameObject

    #endregion
    #region methods
    /// <summary>
    /// Destroys the associated game object
    /// </summary>
    private void SelfDestroy()
    {
        Destroy(gameObject);
    }
    #endregion

    // Update is called once per frame
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime > _maxLifetime)
        {
            SelfDestroy();
        }
    }

}
