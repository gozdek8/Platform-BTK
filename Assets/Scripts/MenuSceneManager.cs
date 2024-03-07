using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour
{

    public GameObject dataBoard;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
        //play button will load the game scene which is in 1st index
    }

    public void ScoreButton()
    {
        DataManager.Instance.LoadData(); //call for latest saved data
        
        dataBoard.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Total enemy killed: " + DataManager.Instance.totalEnemyKilled;
        dataBoard.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Total coins collected: " + DataManager.Instance.totalCoinsCollected;
        dataBoard.SetActive(true);
        dataBoard.transform.GetChild(3).gameObject.SetActive(true);
    }

    public void CloseScoreBoardButton()
    {
        dataBoard.SetActive(false);
        dataBoard.transform.GetChild(3).gameObject.SetActive(false);
    }
    
}
