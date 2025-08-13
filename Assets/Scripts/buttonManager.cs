using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    
    [SerializeField] GameObject PopP;
    [SerializeField] AudioSource click;
    
   public void Restart()
    {
        click.Play();
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;

    }

    //public  IEnumerator WaitForSound()
    //{
    //    yield return new WaitForSeconds(1f);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    Time.timeScale = 1.0f;
    //}


   public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    
    public void PopUP()
    {
        PopP.SetActive(true);
        Time.timeScale = 0;
    }

    public void Yes()
    {
        SceneManager.LoadScene(0);
        PopP.SetActive(false);
    }
    public void No()
    {
        PopP.SetActive(false );
        Time.timeScale = 1f;

    }
}
