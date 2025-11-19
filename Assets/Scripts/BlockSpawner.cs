using UnityEngine;
using System.Collections.Generic;

public class BlockSpawner : MonoBehaviour
{
    public List<GameObject> blockPrefabs = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Add(int Amount)
    {
        for (int i = 0; i < Amount; i++)
        {
            int randomIndex = Random.Range(0, blockPrefabs.Count);
            Instantiate(blockPrefabs[randomIndex], transform.position, Quaternion.identity);
        }
    }

    void Remove()
    {
        foreach (GameObject block in blockPrefabs)
        {
            Destroy(block); 
        }

        blockPrefabs.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Add (100);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Remove();
        }
    }
}
