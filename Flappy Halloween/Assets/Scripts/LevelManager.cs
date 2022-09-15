using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region references

    private ParalaxScroller _myParalaxScroller;

    #endregion
    #region methods
    /// <summary>
    /// Stops the paralax scrollers
    /// </summary>
    public void GameOver() // Estaba en privado
    {
        _myParalaxScroller.enabled = false;
    }
    #endregion

    private void Start()
    {
        _myParalaxScroller = GetComponent<ParalaxScroller>();
    }
}
