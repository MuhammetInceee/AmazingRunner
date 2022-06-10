using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> collectedObj = new List<GameObject>();
    public int score;

    public GameObject levelEndCanvas;

    private void Awake() => AwakeInit();
    private void Update() => UpdateInit();
    private void AwakeInit()
    {
        if (Instance == null) Instance = GameObject.FindObjectOfType<GameManager>();
        else Destroy(gameObject);
    }
    private void UpdateInit()
    {
        
    }
    
}
