using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    #region references
    /// <summary>
    /// Array of prefabs to instantiate as obstacles
    /// </summary>
    [SerializeField]
    private GameObject[] _prefabs;
    /// <summary>
    /// Reference to transform where obstacles will be instantiated
    /// </summary>
    [SerializeField]
    private Transform _spawnTransform;
    #endregion
    #region paramaters
    /// <summary>
    /// Maximum time between obstacles generation
    /// </summary>
    [SerializeField]
    private float _maxTimeInterval = 5.0f;
    /// <summary>
    /// Minimum time between obstacles generation
    /// </summary>
    [SerializeField]
    private float _minTimeInterval = 1.0f;

    private float _randomTime = 0.0f;
    #endregion
    #region properties
    /// <summary>
    /// Elapsed time since last obstacle generation
    /// </summary>
    private float _elapsedTime;
    /// <summary>
    /// Time interval set for next obstacle generation
    /// </summary>
    private float _nextSpawnTime;
    #endregion
    #region methods
    /// <summary>
    /// Method to disable the script and this stop obstacles generation
    /// </summary>
    public void Stop() // En el pdf es privado
    {
        this.enabled = false;

    }
    #endregion
    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        
        
        if(_elapsedTime >= _randomTime)
        {
            Instantiate(_prefabs[Random.Range(0, _prefabs.Length - 1)], _spawnTransform.position, Quaternion.identity);
            _randomTime = Random.Range(_minTimeInterval, _maxTimeInterval);
            _elapsedTime = 0.0f;
        }

    }

}
