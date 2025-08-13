using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{

    [SerializeField] GameObject IP_Panel;
    [SerializeField] GameObject GameMusic;
    [SerializeField] GameObject musicIcon;
    
    public static IntroManager Instance;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void MusicOn()
    {
        GameMusic.SetActive(true);
        musicIcon.SetActive(false);
        

    }
    public void MusicOff()
    {
        musicIcon.SetActive(true);
        GameMusic.SetActive(false);
        
    }

    public void MusicManage()
    {
        if (musicIcon.activeInHierarchy)
        {
            MusicOn();
           
        }
        else
        {
            MusicOff();
            
        }
        
    }
   
    public void Instruct()
    {
        IP_Panel.SetActive(true);
    }

    public void closeIP()
    {
        IP_Panel.SetActive(false);
    }

 

    public void Quit()
    {
        Application.Quit();
    }
   
}
