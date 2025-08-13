using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coloringBlock : MonoBehaviour
{
    public enum BColor {Red, Green, Blue};
    public BColor color;

    private SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Assign();
    }

    void Assign()
    {
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0:
                color=BColor.Red; 
                sr.color=Color.red; break;  
            case 1:     
                color=BColor.Green;      
                sr.color=Color.green; break;
            case 2:
                color=BColor.Blue;
                sr.color=Color.blue; break;
            default:
                break;
        }
    }
}
