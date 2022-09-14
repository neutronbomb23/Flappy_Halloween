using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    #region References
    /// <summary>
    static private GameManager _instance;
    static public GameManager Instance;
    Vector3 movementDirection = Vector3.zero;
    private InputComponent _myInputComponent;
    /// Reference to player
    /// </summary>
    [SerializeField]
    private GameObject _player;
    /// <summary>
    /// Reference to UI Manager
    /// </summary>
    [SerializeField]
    private GameObject _UIManager;
    /// <summary>
    /// Reference to Level Manager
    /// </summary>
    [SerializeField]
    private GameObject _levelManager;
    #endregion
    #region properties
    /// <summary>
    /// True if the Game is running, False otherwise
    /// </summary>
    private bool _isGameRunning;
    /// <summary>
    /// Accesor to get the state of the game
    /// </summary>
    public bool IsGameRunning
    {
        get
        {
            return _isGameRunning;
        }
    }
    #endregion
    #region methods
    /// <summary>
    /// Method to send message Jump to player
    /// </summary>
    public void Jump()
    {
        movementDirection.y = 2.0f; //eje Y positivo, va hacia arriba.
    }
    /// <summary>
    /// Method to manage finalization of the game
    /// </summary>
    public void OnPlayerDies()
    {
        Destroy(gameObject);
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
        _myInputComponent = GetComponent<InputComponent>();
    }
}
