using UnityEngine;

public class ItemBounce : MonoBehaviour
{
    public float bounceHeight = 0.2f; // Adjust how high it bounces
    public float bounceSpeed = 2f;    // Speed of bouncing
    public float rotateSpeed = 50f;   // Speed of rotation

    private float startY;

    void Start()
    {
        startY = transform.position.y; // Store initial position
    }

    void Update()
    {
        // Bounce motion (up and down using sine wave)
        float newY = startY + Mathf.Sin(Time.time * bounceSpeed) * bounceHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Rotate around Y-axis
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
