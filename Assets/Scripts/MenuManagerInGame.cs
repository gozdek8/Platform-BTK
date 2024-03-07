using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerInGame : MonoBehaviour
{
    public GameObject InGameScreen, PauseScreen;
    
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
        Time.timeScale = 1; //resume game time = game
        //load game screen again
        InGameScreen.SetActive(true);
        PauseScreen.SetActive(false);
        
    }
    
    public void PauseButton()
    {
        Time.timeScale = 0; //pause time = pause game
        //load the pause screen
        InGameScreen.SetActive(false);
        PauseScreen.SetActive(true);
        
    }
    
    public void ReplayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        //Replay button will load the game scene which is in 1st index
    }
    
    public void HomeButton()
    {
        Time.timeScale = 1;
        DataManager.Instance.SaveData();
        SceneManager.LoadScene(0);
        //play button will load the game scene which is in 1st index
    }
    
}
