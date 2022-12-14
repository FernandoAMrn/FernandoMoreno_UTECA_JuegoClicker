using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Transform player;
    public GameObject bulletPrefab;
    public Collider2D dodgeCollider;

    public int PHealth;
    public int PMaxHealth;

    public GameObject PHelathBarUI;
    public Slider PSlider;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        PHealth = PMaxHealth;
        PSlider.value = PCalculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
        PSlider.value = PCalculateHealth();
        if (PHealth < PMaxHealth)
        {
            PHelathBarUI.SetActive(true);
        }

        if (PHealth > PMaxHealth)
        {
            PHealth = PMaxHealth;
        }


        //StartCoroutine(shieldDown());
    }

    float PCalculateHealth()
    {
        return PHealth / PMaxHealth;
    }

    
    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;
    }

    public void dodge()
    {
        
        dodgeCollider.enabled = false;
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "MonsterDamage")
        {
            PHealth--;
        }
    }

    //IEnumerator shieldDown()
    //{
    //    yield return new WaitForSeconds(3);
    //    dodgeCollider.enabled = true;
    //}

}
