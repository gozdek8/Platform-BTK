using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyManager : MonoBehaviour
{

    public float damage;
    public float health;

    public Slider slider;
    
    public bool inCollider = false;
    
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !inCollider)
        {
            inCollider = true;
            other.GetComponent<PlayerManager>().getDamage(damage);
        } 
        
        else if (other.tag == "Bullet")
        {
            getDamage(other.GetComponent<BulletManager>().bulletDamage);
            Destroy(other.gameObject);
        } 
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inCollider = false;
        }
        
    }
    
    public void getDamage(float damage)
    {
        if ((health - damage) >= 0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        slider.value = health;
        isDead();   // every damage check if it is dead
    }
    
    void isDead()
    {
        if (health <= 0)
        { 
          DataManager.Instance.EnemyKilled++;
          Destroy(gameObject);
        }
    }
    
}
