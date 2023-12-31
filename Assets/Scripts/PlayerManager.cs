using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float health;
    public bool dead = false;

    Transform muzzle;
    public Transform bullet;
    public float bulletSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        muzzle = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //index 0 -> left click
        {
            ShootBullet();
        }
    }

    public void getDamage(float damage)
    {
        if ((health - damage) >= 0)
        {
            health = health - damage;
        }
        else
        {
            health = 0;
        }
        isDead();   // every damage check if it is dead
    }

    void isDead()
    {
        if (health <= 0)
        {
            dead = true;
        }
    }

    void ShootBullet()
    {
        Transform tempBullet;
        tempBullet = Instantiate(bullet, muzzle.position,Quaternion.identity );
        // (what to create) , (where to create) , (rotation) , (which object's child is this)
        tempBullet.GetComponent<Rigidbody2D>().AddForce(muzzle.forward * bulletSpeed);
                                                      //forward is on Z axis, Let's change the muzzle's rotation
    }
    
}
