using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public MonsterHP healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setMaxHP(maxHealth);
        //cuando empieza se instanciea el mosntru esta a maxima salud
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void TakeDamage (int damage)
    {
        currentHealth --;
        healthbar.setHealth(currentHealth);
    }
}
