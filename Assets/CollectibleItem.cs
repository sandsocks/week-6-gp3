using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public string itemName;
    public int itemID;
    public int Quantity;

    InventorySystem inventorySystem;
    // Start is called before the first frame update
    void Start()
    {
        inventorySystem = GameObject.FindWithTag("Player").GetComponent<InventorySystem>();
    }
    
    public void CollectItem()
    {
        Item itemToAdd = new Item(itemName, itemID, Quantity);
        inventorySystem.AddItem(itemToAdd);
        Destroy(gameObject);
    }
}
