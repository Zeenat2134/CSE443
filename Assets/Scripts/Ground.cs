using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ground : MonoBehaviour
{
    public GameObject gameOver;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Block"))
        {
            GameO();
            
        }
    }

    public void GameO()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

   
}
