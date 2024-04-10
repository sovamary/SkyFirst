using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homeworkspawn : MonoBehaviour
{
    public GameObject cubewaterfall;
    void Start()
    {

    }

    void Update()
    {
        Instantiate(cubewaterfall);
    }
}
