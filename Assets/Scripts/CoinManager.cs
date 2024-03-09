using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    // Start is called before the first frame update

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
            
        } 
    } 
    
}
