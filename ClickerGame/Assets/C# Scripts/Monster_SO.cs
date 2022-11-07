using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Monster", menuName = "Monster")]
public class Monster_SO : ScriptableObject
{

    public new string name;
    public Sprite Art;

    public int attack;
    public int health;
    public int attackWindup;
    public bool isdead;

}
