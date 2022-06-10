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
        if (collision.collider.CompareTag("Obstacle"))
        {
            if(!GameManager.Instance.levelEndCanvas.activeInHierarchy)
                GameManager.Instance.levelEndCanvas.SetActive(true);

            GetComponent<PlayerMovement>().enabled = false;

            //TODO
            //level End Canvas Kapat level sonu butonda
            //Player Movement geri aç
        }
    }
}
