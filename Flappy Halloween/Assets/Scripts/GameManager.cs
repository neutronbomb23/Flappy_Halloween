using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region References
    /// <summary>
    static public GameManager Instance;
    private UIManager _myUIManager;
    Vector3 movementDirection = Vector3.zero;
    private InputComponent _myInputComponent;
    private MovementComponent _myMovementComponent;
    private ObstaclesGenerator _myObstaclesGenerator;
    private LevelManager _myLevelManager;
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
        Debug.Log("gm");
        _myMovementComponent.Jump();

    }
    /// <summary>
    /// Method to manage finalization of the game
    /// </summary>
    public void OnPlayerDies()
    {
        
        Destroy(_player);
        _myObstaclesGenerator.Stop();
        _myUIManager.GameOver();
        //gameOverText.gameObject.SetActive(true);
        _isGameRunning = false;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
         //_myLevelManager.GameOver();
         

    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        _myInputComponent = GetComponent<InputComponent>();
        _myMovementComponent = _player.GetComponent<MovementComponent>();
        _myObstaclesGenerator = GetComponent<ObstaclesGenerator>();
        _myUIManager = GetComponent<UIManager>();


    }
}
