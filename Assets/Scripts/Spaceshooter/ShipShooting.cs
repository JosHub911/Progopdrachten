using UnityEngine;



public class ShipShooting : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] float cooldown = 3f;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer >= cooldown)
        {
            var laser = Instantiate(laserPrefab, transform.position, transform.rotation);
            Destroy(laser, 3f);
            timer = 0;
        }
    }

    public void BoostFireRate(float amount)
    {
        cooldown -= amount;
    }
}
