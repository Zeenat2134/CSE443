using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] Text ScoreT;
    [SerializeField] GameObject WrongP;
    [SerializeField] AudioSource destroyed;

    public GameObject gameOver;

    private int Score=0;
    private int wrongC = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            checkColor(Color.red);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            checkColor(Color.green);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            checkColor(Color.blue);
        }
    }

    void checkColor(Color pressedColor)
    {
        

        var blocks = Object.FindObjectsByType<coloringBlock>(FindObjectsSortMode.None);

        foreach(var block in blocks)
        {
            if (block.transform.position.y > -3.8f)
            {
                if(block.GetComponent<SpriteRenderer>().color == pressedColor)
                {
                    Destroy(block.gameObject);
                    destroyed.Play();
                    Score++;
                    ScoreT.text = "Score: " + Score;
                    return;
                }
                else
                {
                    
                    wrongC++;
                    if (wrongC <= 3)
                    {
                       
                        WrongP.SetActive(true);
                        Destroy(block.gameObject);
                        StartCoroutine(wait());
                    }
                    else
                    {
                        Destroy(block.gameObject);
                        gameOver.SetActive(true);
                        Time.timeScale = 0;
                    }
                    





                }
            }

        }
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        WrongP.SetActive(false);
    }
}
