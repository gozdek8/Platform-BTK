using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] AudioClip coinAudio;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (gameObject.tag == "DifficultCoin")
            {
                DataManager.Instance.CoinsCollected+=2;
                Destroy(gameObject);
            }
            else
            {
                DataManager.Instance.CoinsCollected++;
                Destroy(gameObject);
            }
            gameObject.GetComponent<AudioSource>().Play(); 
        } 
    } 
    
}
