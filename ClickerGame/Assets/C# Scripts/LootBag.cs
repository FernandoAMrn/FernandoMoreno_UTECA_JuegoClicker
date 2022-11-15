using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBag : MonoBehaviour
{
    public GameObject loot;
    public List<Item_SO> lootList = new List<Item_SO>();
    Item_SO droppLoot()
    {
        int randomNumber = Random.Range(1, 101);
        List<Item_SO> possibleItems = new List<Item_SO>();
        foreach (Item_SO item in lootList)
        {
            if (randomNumber <= item.dropChance)
            {
                possibleItems.Add(item);
            }
        }
        if (possibleItems.Count > 0)
        {
            Item_SO droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }
        Debug.Log("No drop");
        return null;
    }

    public void InstantiateLoot(Vector3 spawnPosition)
    {
        Item_SO droppedItem = droppLoot();
        if (droppedItem != null)
        {
            GameObject lootGameObject = Instantiate(loot, spawnPosition, Quaternion.identity);
            lootGameObject.GetComponent<SpriteRenderer>().sprite = droppedItem.icon;
        }

    }
}
