using System.Collections;
using System.Collections.Generic;
using TigerForge;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    //for score board ...
    /*
     private int shotBullet;
     public int shotBullet;
     */
    private int coinsCollected;
    public int totalCoinsCollected;
    private int enemyKilled;
    public int totalEnemyKilled;
    //... & Savement
    private EasyFileSave myFile;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            StartProcess();
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     public int ShotBullet
    {
        get
        {
            return shotBullet;
        }

        set
        {
            shotBullet = value;
        }
    }
     */
    
    public int CoinsCollected
    {
        get
        {
            return coinsCollected;
            
        }

        set
        {
            coinsCollected = value;
            GameObject.Find("CoinsCollectedText").GetComponent<TextMeshProUGUI>().text = "Coins collected: " + coinsCollected;
        }
    }

    public int EnemyKilled
    {
        get
        {
            return enemyKilled;
        }
        set
        {
            enemyKilled = value;
            print("enemy value is setted");
            GameObject.Find("EnemyKilledText").GetComponent<TextMeshProUGUI>().text = "Enemy killed: " + enemyKilled;
            print("can it print to screen tho?");
        }
    }

    void StartProcess()
    {
        myFile = new EasyFileSave();
        LoadData();
    }

    public void SaveData()
    {
        totalEnemyKilled += totalEnemyKilled;
        totalCoinsCollected += coinsCollected;
        
        myFile.Add("totalEnemyKilled", totalEnemyKilled);
        myFile.Add("totalCoinsCollected", totalCoinsCollected);

        myFile.Save();
    }

    public void LoadData()
    {
        if (myFile.Load())
        {
            totalEnemyKilled = myFile.GetInt("totalEnemyKilled");
            totalCoinsCollected = myFile.GetInt("totalCoinsCollected");
        }
    }
    
}
