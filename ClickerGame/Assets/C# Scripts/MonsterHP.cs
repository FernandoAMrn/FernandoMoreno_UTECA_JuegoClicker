using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MonsterHP : MonoBehaviour
{
    public Slider slider;
    
    public void setMaxHP(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }    
    public void setHealth(int health)
    {
        slider.value = health;
    }
}
