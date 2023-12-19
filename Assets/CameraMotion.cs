using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 30f;
    public float ySpeed = 2f;

    void Update()
    {
        // Camera Rotation
        float horizontalRotation = Input.GetAxis("Horizontal");
        float verticalRotation = Input.GetAxis("Vertical");
        Vector3 rotation = new Vector3(verticalRotation, horizontalRotation, 0f) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);

        // Player Movement
        float horizontalInput = Input.GetAxis("HorizontalMovement");
        float verticalInput = Input.GetAxis("VerticalMovement");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Increase y-axis component
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = transform.position;
            position.y += ySpeed;
            transform.position = position;
        }

        // Decrease y-axis component
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = transform.position;
            position.y -= ySpeed;
            transform.position = position;
        }
    }
}
