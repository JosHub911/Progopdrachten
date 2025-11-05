using UnityEngine;



public class ShipPickupTrigger : MonoBehaviour
{
    [SerializeField] ShipInventory inventory;
    [SerializeField] ShipUI ui;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Color c = other.GetComponent<Renderer>().material.color;
            inventory.AddItem(c);
            ui.UpdateItemUI(c);
            Destroy(other.gameObject);
        }
    }
}
