using UnityEngine;

public class Ballen : MonoBehaviour
{
    public GameObject prefab;


    private float elapsedTime = 0f;

    private void CreateBall(Color c, Vector3 position)
    {

        GameObject ball = Instantiate(prefab);
        Material material = ball.GetComponent<MeshRenderer>().material;

        // voor CORE pipeline
        material.SetColor("_Color", c);

        //Voor URP
        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", c);

        }

        ball.transform.localPosition = position;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);

        Color randColor = new Color(r, g, b, 1f);
        Vector3 RandPosition = new Vector3(x, y, z);
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            CreateBall(randColor, RandPosition);
            elapsedTime = 0f;
        }

        
    }
}
