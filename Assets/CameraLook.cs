using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotación vertical de la cámara
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotación horizontal del cuerpo del jugador
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}