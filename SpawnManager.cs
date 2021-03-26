using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private static SpawnManager _instance;
    public static SpawnManager Instance
    {
        get
        {
            if(_instance == null)
                Debug.LogError("SpawnManager is NULL");

                return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    } 

   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void StartSpawning()
    {
        Debug.Log("Spawn Started");
    }


}
