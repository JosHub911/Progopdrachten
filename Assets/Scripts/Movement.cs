using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float sprintMultiplier = 2f;

    void Update()
    {
        float currentSpeed = speed;

        // Sprinting with LeftShift
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            currentSpeed *= sprintMultiplier;
        }

        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        transform.Translate(direction.normalized * currentSpeed * Time.deltaTime);
    }
}
