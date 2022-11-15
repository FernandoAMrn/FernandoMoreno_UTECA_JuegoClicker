using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewItem", menuName = "Item/Create New Item")]
public class Item_SO : ScriptableObject
{
    public int id;
    public string itemName;
    public int bonusHP;
    public int bonusDmg;
    public int dropChance;

    public Sprite icon;

    public Item_SO(string itemName, int dropChance)
    {
        this.itemName = itemName;
        this.dropChance = dropChance;
    }
}
