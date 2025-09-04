using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        // Obtenemos la entrada del teclado
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // Movemos el objeto en la dirección correspondiente
        transform.Translate(moveX, 0, moveZ);
    }
}