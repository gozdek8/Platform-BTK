using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestManager : MonoBehaviour
{

    public GameObject chest;
    private bool isEnough = false;
    public AudioSource audioClip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        OpenChest();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        chest.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    void OpenChest()
    {
        if (DataManager.Instance.CoinsCollected == 43)
        {
            GetComponent<Animator>().SetBool("isEnough",true);
            audioClip.Play();
            SceneManager.LoadScene(2);
        }
        else
        {
            chest.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
