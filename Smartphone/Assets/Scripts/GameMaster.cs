using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public GameObject restartPanel;
    public Text score;
    private bool asLost;

    private void Update()
    {
        if(asLost == false)
        {
            score.text = Time.time.ToString("F0");
        }
    }

    public void GameOver()
    {
        asLost = true;
        Invoke("Delay", 1.5f);
    }

    void Delay()
    {
        restartPanel.SetActive(true);
    }
    
    public void GoToGameScene() 
    {
        SceneManager.LoadScene("Game");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
