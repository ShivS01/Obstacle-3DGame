﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevelUI()
    {
        completeLevelUI.SetActive(true);
    }

    public void CompleteLevel()
    {
        Debug.Log("yeet");
    }

   public void EndGame()
    {
        if (gameEnded == false) 
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
