using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {
        SpawnManager.Instance.StartSpawning();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UIManager.Instance.UpdateScore(10);
        }

    }


}
