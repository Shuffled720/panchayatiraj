using UnityEngine;

public class MotionCamera : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 2f;

    private void Update()
    {
        HandleMovementInput();
        HandleRotationInput();
    }

    void HandleMovementInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    void HandleRotationInput()
    {
        if (Input.GetMouseButton(1)) // Right mouse button is held down
        {
            float mouseX = Input.GetAxis("Mouse X");

            Vector3 rotation = new Vector3(0f, mouseX, 0f) * rotationSpeed;
            transform.Rotate(rotation);
        }
    }
}
