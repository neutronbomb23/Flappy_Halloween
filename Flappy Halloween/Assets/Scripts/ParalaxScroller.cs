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
    private Vector2 offset;
     #endregion

    #region References
    /// <summary>
    /// Reference to own Sprite Renderer
    /// </summary>
     private SpriteRenderer _mySpriteRenderer;

    /// <summary>
    /// Reference to own Material
    /// </summary>
    private Material _myMaterial;

    private Transform _myTransform;
    #endregion

    #region methods
    /// <summary>
    /// Disables the component, so the texture movement stops
    /// </summary>
    public void Stop() // era privado
    {
        _mySpriteRenderer.enabled = false;
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();// Transform access
        _mySpriteRenderer = GetComponent<SpriteRenderer>();// SpriteRenderer access
        _myMaterial = GetComponent<SpriteRenderer>().material;// Material access
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = _scrollSpeed * Time.deltaTime*Vector2.right; //Backgroud movement
        _myMaterial.mainTextureOffset += offset;
    }
}
