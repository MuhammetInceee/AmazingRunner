using UnityEngine;

public class PlayerCollisionDetector : MonoBehaviour
{
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
            if(!loseCanvas.activeInHierarchy)
                loseCanvas.SetActive(true);
        }

        if (collision.collider.CompareTag("Finish"))
        {
            if (!winCanvas.activeInHierarchy)
                winCanvas.SetActive(true);
        }
    }
}
