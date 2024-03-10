using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinToHome : MonoBehaviour
{
    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
}
