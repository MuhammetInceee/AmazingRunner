using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> levelList = new List<GameObject>();
    
    [SerializeField] private TextMeshProUGUI currentLevelText;
    [SerializeField] private TextMeshProUGUI nextLevelText;

    private void Update() => UpdateInit();

    private void UpdateInit()
    {
        LevelActivator();
    }
    
    private void LevelActivator()
    {
        if (PlayerPrefs.GetInt("Level1Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 0)
                    continue;
                else
                    levelList[i].SetActive(false);
            }

            TextChanger("1", "2");
        }
        
        if (PlayerPrefs.GetInt("Level2Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 1)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("2", "3");
        }
        
        if (PlayerPrefs.GetInt("Level3Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 2)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("3", "4");
        }
        
        if (PlayerPrefs.GetInt("Level4Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 3)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("4", "5");
        }
        
        if (PlayerPrefs.GetInt("Level5Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 4)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("5", "6");
        }
        
        if (PlayerPrefs.GetInt("Level6Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 5)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("6", "7");
        }
        
        if (PlayerPrefs.GetInt("Level7Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 6)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("7", "8");
        }
        
        if (PlayerPrefs.GetInt("Level8Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 7)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("8", "9");
        }
        
        if (PlayerPrefs.GetInt("Level9Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 8)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("9", "10");
        }
        
        if (PlayerPrefs.GetInt("Level10Lock") == 1)
        {
            for (int i = 0; i < levelList.Count; i++)
            {
                if(i == 9)
                    continue;
                else
                    levelList[i].SetActive(false);
            }
            
            TextChanger("10", "10");
        }
    }

    private void TextChanger(string current, string next)
    {
        currentLevelText.text = current;
        nextLevelText.text = next;
    }
}
