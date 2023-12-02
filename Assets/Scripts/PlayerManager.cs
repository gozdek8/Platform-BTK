using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float health;

    public bool dead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void isDead()
    {
        if (health <= 0)
        {
            dead = true;
        }
    }
    
}
