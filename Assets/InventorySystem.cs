using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]


public class SerializableKeyValuePair<TKey, TValue>
{
    public TKey Key;
    public TValue Value;

    public SerializableKeyValuePair(TKey key, TValue value) 
    {
        Key = key;
        Value = value;
    }
}
public class InventorySystem : MonoBehaviour
{
    public Dictionary<int,Item> inventory = new Dictionary<int, Item>();
    public List<SerializableKeyValuePair<int, Item>> inventoryList = new List<SerializableKeyValuePair<int, Item>>();

    private void SyncListWithDictionary()
    {
        inventoryList.Clear();
        foreach (var pair in inventory)
        {
            inventoryList.Add(new SerializableKeyValuePair<int, Item>(pair.Key, pair.Value));
        }
    }
    public void AddItem(Item item)
    {
        if (inventory.ContainsKey(item.itemID)) 
        { 

        }
        else
        {
            inventory.Add(item.itemID, item);
        }
        SyncListWithDictionary();
    }

    public bool RemoveItem(int itemID)
    {
        bool removed = inventory.Remove(itemID);
        if (removed)
        {

        }
        return removed;
    }

    public bool CheckItem(int itemID)
    {
        return inventory.ContainsKey(itemID);
    }
}
