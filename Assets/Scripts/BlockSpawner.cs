using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class BlockSpawner : MonoBehaviour
{

    [SerializeField] GameObject Block;

    public float spawnInterval = 1.5f;
    public float X_Axis = 7.5f;

    private void Start()
    {
        InvokeRepeating("SpawnBlock", 1f, 4f);
    }

    void SpawnBlock()
    {
       float x= Random.Range(-X_Axis, X_Axis);
        Vector3 pos = new Vector3(x,5,0);
        Instantiate(Block, pos, Quaternion.identity);
    }
}
