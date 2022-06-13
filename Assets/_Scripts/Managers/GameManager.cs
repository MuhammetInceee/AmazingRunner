using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> collectedObj = new List<GameObject>();
    public int score;

    public GameObject levelLoseCanvas;
    public GameObject levelWinCanvas;

    [SerializeField] private TextMeshProUGUI scoreText;
    
    public GameObject tapToStart;

    [SerializeField] private PlayerMovement playerMovement;
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
    }

    private void PlayerMovementChecker()
    {
        if (tapToStart.activeInHierarchy || levelLoseCanvas.activeInHierarchy || levelWinCanvas.activeInHierarchy)
        {
            playerMovement.enabled = false;
        }
        else
        {
            playerMovement.enabled = true;
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
    
}
