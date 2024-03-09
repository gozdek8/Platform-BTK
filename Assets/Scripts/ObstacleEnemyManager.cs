using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Update = UnityEngine.PlayerLoop.Update;

public class ObstacleEnemyManager : MonoBehaviour
{
    public GameObject mace1, mace2;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && gameObject.tag == "Obstacle")
        {
            other.gameObject.GetComponent<PlayerManager>().getDamage(7);
        }
        else
        {
            other.gameObject.GetComponent<PlayerManager>().getDamage(13);
        }
    }
}
