using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DataManager.Instance.CoinsCollected = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
