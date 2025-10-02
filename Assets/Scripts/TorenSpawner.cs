using UnityEngine;

public class TorenSpawner : MonoBehaviour
{
    public GameObject torenPrefab; // Assign the Toren prefab in the Inspector


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {
           CreateToren();
        }
    }


    private void CreateToren()
    {
        

        float x1 = Random.Range(-10.0f, 10.0f);
        float y1 = 0.0f;
        float z1 = Random.Range(-10.0f, 10.0f);

        float x2 = Random.Range(-10.0f, 10.0f);
        float y2 = Random.Range(-10.0f, 10.0f);
        float z2 = Random.Range(-10.0f, 10.0f);

        Vector3 spawnPosition = new Vector3(x1, y1, z1);
        torenPrefab.transform.localScale = new Vector3(x2, y2, z2);



        Instantiate(torenPrefab, spawnPosition, Quaternion.identity);
    }

}
