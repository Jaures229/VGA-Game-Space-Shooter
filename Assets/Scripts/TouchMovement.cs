using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody2D rb;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = mainCamera.ScreenToWorldPoint(touch.position);
            touchPos.z = 0f;

            Vector2 targetPos = new Vector2(touchPos.x, touchPos.y);
            float fxTime = Time.fixedDeltaTime;
            Vector2 newPosition = Vector2.MoveTowards(rb.position, targetPos, speed * fxTime); 
        }

       // rb.MovePosition(newPosition);
    }
}
