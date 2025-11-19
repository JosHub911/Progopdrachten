using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventorySystem inventorySystem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            inventorySystem.AddItem(InventorySystem.ItemType.Medipack);

        if (Input.GetKeyDown(KeyCode.R))
            inventorySystem.RemoveItem(InventorySystem.ItemType.Medipack);

        if (Input.GetKeyDown(KeyCode.G))
            inventorySystem.AddItem(InventorySystem.ItemType.Guns);

        if (Input.GetKeyDown(KeyCode.W))
            inventorySystem.RemoveItem(InventorySystem.ItemType.Guns);

        if (Input.GetKeyDown(KeyCode.Q))
            inventorySystem.AddItem(InventorySystem.ItemType.KeyCard);

        if (Input.GetKeyDown(KeyCode.E))
            inventorySystem.RemoveItem(InventorySystem.ItemType.KeyCard);
    }
}
