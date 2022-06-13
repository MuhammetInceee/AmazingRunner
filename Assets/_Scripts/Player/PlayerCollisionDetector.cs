using System;
using System.Linq;
using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
    private LevelManager _levelManager;
    public PlayerMovement playerMovement;
    
    private void Start() => StartInit();

    private void StartInit()
    {
        _levelManager = GameObject.FindObjectOfType<LevelManager>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            var collidedGO = other.gameObject;
            var collectedList = GameManager.Instance.collectedObj;

            GameManager.Instance.score++;
            if (collectedList.Contains(collidedGO))
            {
                collectedList.Remove(collidedGO);
                Destroy(collidedGO);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var loseCanvas = GameManager.Instance.levelLoseCanvas;
        var winCanvas = GameManager.Instance.levelWinCanvas;

        if (collision.collider.CompareTag("Obstacle"))
        {
            if (!loseCanvas.activeInHierarchy)
                loseCanvas.SetActive(true);
        }

        if (collision.collider.CompareTag("Finish"))
        {
            if (!winCanvas.activeInHierarchy)
            {
                winCanvas.SetActive(true);
            }


            _levelManager.currentLevel = _levelManager.levelList.FirstOrDefault(b => b.activeInHierarchy);
            PlayerPrefs.SetInt(_levelManager.currentLevel.name + "Lock", 0);
        }
    }
}