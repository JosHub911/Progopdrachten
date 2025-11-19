using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private int _worldMedipack = 5;
    [SerializeField] private int _worldGuns = 3;
    [SerializeField] private int _worldKeyCard = 2;

    private List<Item> _inventory = new List<Item>();

    public enum ItemType
    {
        Medipack,
        Guns,
        KeyCard
    }

    // ADD ITEM
    public void AddItem(ItemType type)
    {
        switch (type)
        {
            case ItemType.Medipack:
                if (_worldMedipack > 0)
                {
                    _worldMedipack--;
                    _inventory.Add(new MediPack());
                }
                break;

            case ItemType.Guns:
                if (_worldGuns > 0)
                {
                    _worldGuns--;
                    _inventory.Add(new Guns());
                }
                break;

            case ItemType.KeyCard:
                if (_worldKeyCard > 0)
                {
                    _worldKeyCard--;
                    _inventory.Add(new KeyCard());
                }
                break;
        }

        PrintInventories(); // AUTO PRINT
    }

    // REMOVE ITEM
    public void RemoveItem(ItemType type)
    {
        Item itemToRemove = null;

        foreach (var item in _inventory)
        {
            if ((type == ItemType.Medipack && item is MediPack) ||
                (type == ItemType.Guns && item is Guns) ||
                (type == ItemType.KeyCard && item is KeyCard))
            {
                itemToRemove = item;
                break;
            }
        }

        if (itemToRemove != null)
        {
            _inventory.Remove(itemToRemove);

            switch (type)
            {
                case ItemType.Medipack:
                    _worldMedipack++;
                    break;

                case ItemType.Guns:
                    _worldGuns++;
                    break;

                case ItemType.KeyCard:
                    _worldKeyCard++;
                    break;
            }
        }

        PrintInventories(); // AUTO PRINT
    }

    // PRINT INVENTORIES
    private void PrintInventories()
    {
        int invMedipacks = 0;
        int invGuns = 0;
        int invKeycards = 0;

        foreach (Item item in _inventory)
        {
            if (item is MediPack) invMedipacks++;
            if (item is Guns) invGuns++;
            if (item is KeyCard) invKeycards++;
        }

        Debug.Log("------------- INVENTORY STATUS -------------");
        Debug.Log("Items in de wereld:");
        Debug.Log($"Medipacks: {_worldMedipack}");
        Debug.Log($"Guns: {_worldGuns}");
        Debug.Log($"Keycards: {_worldKeyCard}");

        Debug.Log("Items in inventory:");
        Debug.Log($"Medipacks: {invMedipacks}");
        Debug.Log($"Guns: {invGuns}");
        Debug.Log($"Keycards: {invKeycards}");
        Debug.Log("--------------------------------------------");
    }
}
