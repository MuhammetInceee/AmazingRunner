using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> levelList = new List<GameObject>();
    public GameObject currentLevel;
    [SerializeField] private bool isClearPP;
    [SerializeField] private bool wannaSeePP;
    
    [SerializeField] private TextMeshProUGUI currentLevelText;
    [SerializeField] private TextMeshProUGUI nextLevelText;

    private void Update() => UpdateInit();

    private void Start()
    {
        if(isClearPP)
            PlayerPrefs.SetInt("Level1Lock", 1);
    }

    private void UpdateInit()
    {
        PlayerPrefsVisualizer();
    }

    public void TextChanger(string current, string next)
    {
        currentLevelText.text = current;
        nextLevelText.text = next;
    }

    private void PlayerPrefsVisualizer()
    {
        if(!wannaSeePP) return;
        print("Level 1 " + PlayerPrefs.GetInt("Level1Lock"));
        print("Level 2 " + PlayerPrefs.GetInt("Level2Lock"));
        print("Level 3 " + PlayerPrefs.GetInt("Level3Lock"));
        print("Level 4 " + PlayerPrefs.GetInt("Level4Lock"));
        print("Level 5 " + PlayerPrefs.GetInt("Level5Lock"));
        print("Level 6 " + PlayerPrefs.GetInt("Level6Lock"));
        print("Level 7 " + PlayerPrefs.GetInt("Level7Lock"));
        print("Level 8 " + PlayerPrefs.GetInt("Level8Lock"));
        print("Level 9 " + PlayerPrefs.GetInt("Level9Lock"));
        print("Level 10 " + PlayerPrefs.GetInt("Level10Lock"));
    }
}
