using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    private Transform playerTransform;
    public GameObject bombPrefab;
    
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<PlayerController>().transform;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bombPrefab, playerTransform.position - new Vector3(0, 1, 0), playerTransform.rotation);
        }
    }
}
