using UnityEngine;

public class PERSPECTIVEPAN : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get input from arrow keys or WASD
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Move the camera
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
