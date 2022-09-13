using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxScroller : MonoBehaviour
{
    #region Parameters
    /// <summary>
    /// Speed used to move the texture
    /// </summary>
    [SerializeField]
    private float _scrollSpeed;
    #endregion  

    #region references
    ///<summary>
    ///reference to own sprite renderer
    ///<summary>
    private SpriteRenderer _mySpriteRenderer;
    ///<summary>
    /// Reference to own material
    ///<summary>
    private Material _myMaterial;
    [SerializeField]
    private float _offset;
    private Vector2 _vectorPos;
    private float _newXpos;
    #endregion

    #region methods
    ///<summary>
    /// Disables the component, so the texture movement stops
    ///<summary>
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _vectorPos = transform.position;
       

    }

    // Update is called once per frame
    void Update()
    {
        _newXpos = Mathf.Repeat(Time.time * _scrollSpeed, _offset);
        transform.position = _vectorPos + Vector2.left * _newXpos;

    }

}
