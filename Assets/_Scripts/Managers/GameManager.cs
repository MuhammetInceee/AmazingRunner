using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private PlayerMovement playerMovement;
    
    [Header("About Interactable Lists : "), Space]
    public List<GameObject> collectedObj = new List<GameObject>();
    public List<GameObject> obstacleList = new List<GameObject>();

    [Header("About Score : "), Space]
    public int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    [Header("About UI Canvas : "),Space]
    public GameObject levelLoseCanvas;
    public GameObject levelWinCanvas;
    public GameObject tapToStart;
    
    [Header("About Animation : "), Space]
    [SerializeField] private Animator playerAnim;
    private static readonly int TimeToRun = Animator.StringToHash("timeToRun");

    [Header("About Sounds : "), Space] 
    public AudioSource collectAudio;
    public AudioSource obstacleAudio;
    
    private void Awake() => AwakeInit();
    private void Update() => UpdateInit();
    private void AwakeInit()
    {
        if (Instance == null) Instance = GameObject.FindObjectOfType<GameManager>();
        else Destroy(gameObject);
    }
    private void UpdateInit()
    {
        scoreText.text = "Score : " + score;
        TapToStartControl();
        PlayerMovementChecker();
        CollectableRotator();
        ObstacleRotator();
    }

    private void PlayerMovementChecker()
    {
        if (tapToStart.activeInHierarchy || levelLoseCanvas.activeInHierarchy || levelWinCanvas.activeInHierarchy)
        {
            playerMovement.enabled = false;
            playerAnim.SetBool(TimeToRun, false);
        }
        else
        {
            playerMovement.enabled = true;
            playerAnim.enabled = true;
            playerAnim.SetBool(TimeToRun, true);

        }
    }

    private void TapToStartControl()
    {
        if(!tapToStart.activeInHierarchy) return;

        if (Input.GetMouseButtonDown(0))
            tapToStart.SetActive(false);
    }

    private void CollectableRotator()
    {
        foreach (var elements in collectedObj)
        {
            elements.transform.Rotate(0,1,0);
        }
    }

    private void ObstacleRotator()
    {
        foreach (var elements in obstacleList)
        {
            elements.transform.Rotate(1,0,0);
        }
    }
    
}
