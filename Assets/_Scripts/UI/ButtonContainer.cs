using System;
using UnityEngine;

public class ButtonContainer : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager;

    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 playerBeginPos;

    private Vector3 PlayerPos
    {
        get => player.transform.position;
        set => player.transform.position = value;
    }

    private void Start()
    {
        LevelActivator();
    }

    public void RestartButton()
    {
        PlayerPos = playerBeginPos;
        GameManager.Instance.levelLoseCanvas.SetActive(false);
        GameManager.Instance.tapToStart.SetActive(true);
    }
    public void NextLevelButton()
    {
        PlayerPrefsChanger();
        LevelActivator();
        PlayerPos = playerBeginPos;
        GameManager.Instance.levelWinCanvas.SetActive(false);
        GameManager.Instance.tapToStart.SetActive(true);
    }
    
        private void LevelActivator()
    {
        if (PlayerPrefs.GetInt("Level1Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[0].SetActive(true);
            }

            levelManager.TextChanger("1", "2");
        }
        
        else if (PlayerPrefs.GetInt("Level2Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[1].SetActive(true);
            }
            
            levelManager.TextChanger("2", "3");
        }
        
        else if (PlayerPrefs.GetInt("Level3Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[2].SetActive(true);
            }
            
            levelManager.TextChanger("3", "4");
        }
        
        else if (PlayerPrefs.GetInt("Level4Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[3].SetActive(true);
            }
            
            levelManager.TextChanger("4", "5");
        }
        
        else if (PlayerPrefs.GetInt("Level5Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[4].SetActive(true);
            }
            
            levelManager.TextChanger("5", "6");
        }
        
        else if (PlayerPrefs.GetInt("Level6Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[5].SetActive(true);
            }
            
            levelManager.TextChanger("6", "7");
        }
        
        else if (PlayerPrefs.GetInt("Level7Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[6].SetActive(true);
            }
            
            levelManager.TextChanger("7", "8");
        }
        
        else if (PlayerPrefs.GetInt("Level8Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[7].SetActive(true);
            }
            
            levelManager.TextChanger("8", "9");
        }
        
        else if (PlayerPrefs.GetInt("Level9Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[8].SetActive(true);
            }
            
            levelManager.TextChanger("9", "10");
        }
        
        else if (PlayerPrefs.GetInt("Level10Lock") == 1)
        {
            for (int i = 0; i < levelManager.levelList.Count; i++)
            {
                levelManager.levelList[i].SetActive(false);
                levelManager.levelList[9].SetActive(true);
            }
            
            levelManager.TextChanger("10", "10");
        }
    }

    private void PlayerPrefsChanger()
    {
        string subs = levelManager.currentLevel.name.Substring(levelManager.currentLevel.name.Length - 1);
        PlayerPrefs.SetInt("Level" + (int.Parse(subs) + 1) + "Lock", 1);
    }
}