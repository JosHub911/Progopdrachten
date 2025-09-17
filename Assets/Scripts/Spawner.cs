using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Assign a Cylinder prefab in the Inspector
    public GameObject prefab;

    private void SpawnCylinder(Vector3 worldPosition)
    {
        if (prefab == null)
        {
            Debug.LogWarning("Spawner: prefab is not assigned!");
            return;
        }

        Instantiate(prefab, worldPosition, Quaternion.identity);

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-5f, 5f);
            float z = Random.Range(-5f, 5f);

            Vector3 randPosition = new Vector3(x, y, z);

          
            SpawnCylinder(transform.position + randPosition);
        }
    }
}
