using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;     // How fast the camera moves
    public float min, max;  // The minimum and maximum rotation for camera

    private float currentRot;

    void Start()
    {
        // Initial rotation
        currentRot = transform.eulerAngles.x;
    }

    void Update()
    {
        // Move relative to input, speed and FPS, clamp it to bounds, rotate to new rotation
        currentRot += -Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
        currentRot = Mathf.Clamp(currentRot, min, max);
        transform.rotation = Quaternion.Euler(currentRot, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}