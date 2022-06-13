using UnityEngine;
[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Player Speeds")] 
    [SerializeField] private float verticalSpeed;
    [SerializeField] private float horizontalSpeed;

    [Header("Borders"), Space] 
    [SerializeField] private float leftSideBorder;
    [SerializeField] private float rightSideBorder;


    private Vector3 Pos
    {
        get => transform.position;
        set => transform.position = value;
    }

    private static Touch Touch => Input.GetTouch(0);

    private void Update() => UpdateInit();

    private void UpdateInit()
    {
        VerticalMovement();
        HorizontalMovement();
        MovementBorder();
    }

    private void VerticalMovement() =>
        transform.Translate(0, 0, (verticalSpeed * Time.deltaTime));

    private void HorizontalMovement()
    {
        if (Input.touchCount <= 0) return;

        if (Touch.phase == TouchPhase.Moved)
        {
            Pos = new Vector3(Pos.x + Touch.deltaPosition.x * (horizontalSpeed * Time.deltaTime), Pos.y, Pos.z);
            
        }
    }

    private void MovementBorder()
    {
        if (Pos.x < leftSideBorder)
            Pos = new Vector3(leftSideBorder, Pos.y, Pos.z);

        if (Pos.x > rightSideBorder)
            Pos = new Vector3(rightSideBorder, Pos.y, Pos.z);
    }
    
    
}