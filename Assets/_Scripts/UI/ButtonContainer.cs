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

    public void RestartButton()
    {
        PlayerPos = playerBeginPos;
        GameManager.Instance.levelLoseCanvas.SetActive(false);
        GameManager.Instance.tapToStart.SetActive(true);
    }
    public void NextLevelButton()
    {
        PlayerPrefsChanger();
        PlayerPos = playerBeginPos;
        GameManager.Instance.levelWinCanvas.SetActive(false);
        GameManager.Instance.tapToStart.SetActive(true);
    }
    private void PlayerPrefsChanger()
    {
        if (PlayerPrefs.GetInt("Level2Lock") == 0)
            PlayerPrefs.SetInt("Level2Lock", 1);
        
        if (PlayerPrefs.GetInt("Level3Lock") == 0)
            PlayerPrefs.SetInt("Level3Lock", 1);
        
        if (PlayerPrefs.GetInt("Level4Lock") == 0)
            PlayerPrefs.SetInt("Level4Lock", 1);
        
        if (PlayerPrefs.GetInt("Level5Lock") == 0)
            PlayerPrefs.SetInt("Level5Lock", 1);
        
        if (PlayerPrefs.GetInt("Level6Lock") == 0)
            PlayerPrefs.SetInt("Level6Lock", 1);
        
        if (PlayerPrefs.GetInt("Level7Lock") == 0)
            PlayerPrefs.SetInt("Level7Lock", 1);
        
        if (PlayerPrefs.GetInt("Level8Lock") == 0)
            PlayerPrefs.SetInt("Level8Lock", 1);
        
        if (PlayerPrefs.GetInt("Level9Lock") == 0)
            PlayerPrefs.SetInt("Level9Lock", 1);
        
        if (PlayerPrefs.GetInt("Level10Lock") == 0)
            PlayerPrefs.SetInt("Level10Lock", 1);
    }
}