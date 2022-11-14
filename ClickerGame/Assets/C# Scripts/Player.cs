using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform player;
    public GameObject bulletPrefab;
    public Collider2D dodgeCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Shoot"))
        //{
        //    shootBullet();
        //}

        //if (Input.GetButtonDown("Dodge"))
        //{
        //    dodge();
        //}
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

}
