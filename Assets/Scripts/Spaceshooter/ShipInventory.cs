using UnityEngine;
using System.Collections.Generic;



public class ShipInventory : MonoBehaviour
{
    public List<Color> items = new List<Color>();
    public int activeIndex = -1;

    public void AddItem(Color c)
    {
        items.Add(c);
        activeIndex = items.Count - 1;
    }

    public Color? CycleItem()
    {
        if (items.Count == 0) return null;

        activeIndex = (activeIndex + 1) % items.Count;
        return items[activeIndex];
    }

    public Color? UseItem()
    {
        if (items.Count == 0 || activeIndex < 0) return null;

        Color c = items[activeIndex];
        items.RemoveAt(activeIndex);

        activeIndex = items.Count > 0 ? items.Count - 1 : -1;

        return c;
    }
}
