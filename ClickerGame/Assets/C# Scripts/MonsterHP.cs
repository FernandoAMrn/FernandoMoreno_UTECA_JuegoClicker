using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHP : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthBarUI;
    public Slider slider;
    
    public Transform deEnemy;

    

    

     void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();

    }

    private void Update()
    {
        slider.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if (health <= 0 )
        {
            GetComponent<LootBag>().InstantiateLoot(transform.position);
            Destroy(this.gameObject);
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Damage")
        {
            health--;
        }
    }

    
}
