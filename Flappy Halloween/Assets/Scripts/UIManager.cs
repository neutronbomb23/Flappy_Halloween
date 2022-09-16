using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region references
    /// <summary>
    /// Reference to object containing GameOver text element
    /// </summary>
    [SerializeField]
    private GameObject _gameOverObject;
    #endregion

    #region methods
    /// <summary>
    /// Method callled to activate the GameOver text element
    /// </summary>
    public void GameOver() //Estaba privado
    {
        _gameOverObject.gameObject.SetActive(true);

    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _gameOverObject.gameObject.SetActive(false);
    }

}
