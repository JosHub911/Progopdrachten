using UnityEngine;


public class ShipMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 25f;

    void Update()
    {
        transform.position += transform.forward * moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Rotate(Vector3.up * rotationSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }

    public void BoostSpeed(float amount)
    {
        moveSpeed += amount;
    }

    public void BoostRotation(float amount)
    {
        rotationSpeed += amount;
    }
}
