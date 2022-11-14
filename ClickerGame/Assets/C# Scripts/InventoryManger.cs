using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManger : MonoBehaviour
{
    public static InventoryManger Instance;
    public List<Item_SO> Items = new List<Item_SO>();

    public Transform ItemContent;
    public GameObject InventoryItem;



    private void Awake()
    {
        Instance = this;
    }

    public void Add (Item_SO item)
    {
        Items.Add(item);
    }

    public void  Remove(Item_SO item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        foreach (Transform item in ItemContent)//Limpia contenido antes de abrir inventorio.
        {
            Destroy(item.gameObject);
        }
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }
        
    }

}
