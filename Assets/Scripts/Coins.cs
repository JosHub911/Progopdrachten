using UnityEngine;
using System; 
public class Coins : MonoBehaviour
{
    public static event Action OnCoinCollected;

    private void OnTriggerEnter(Collider other)
    {
      //action event
      if (other.CompareTag("Player"))
      {
          OnCoinCollected?.Invoke();
          Destroy(gameObject);
        }
    }
}
