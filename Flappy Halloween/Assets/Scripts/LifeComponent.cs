using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeComponent : MonoBehaviour
{
    #region References
    [SerializeField]
    private GameObject _gameManager;
    #endregion

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.OnPlayerDies();
    
    }

}
