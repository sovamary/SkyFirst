using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject pr;
    void Start()
    {
        Instantiate(pr);
    }

    void Update()
    {
        
    }
}
