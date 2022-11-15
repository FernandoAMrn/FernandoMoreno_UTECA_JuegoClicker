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

    [SerializeField]
    private GameObject monsterDamage;
    [SerializeField]
    private float damageInterval = 5f;

    

     void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
        StartCoroutine(spawnMonsterDmg(damageInterval, monsterDamage));
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

    private IEnumerator spawnMonsterDmg (float interval, GameObject monsterDmg)
    {
        
        yield return new WaitForSeconds(interval);
        Vector3 position = transform.position; //posicion del enemigo
        GameObject newEnemy = Instantiate(monsterDmg, position, Quaternion.identity);//spawnea el daño
        StartCoroutine(spawnMonsterDmg(interval, monsterDmg)); //comienza la corrutina.
    }
    
}
