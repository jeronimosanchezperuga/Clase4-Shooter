﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour
{

    public GameObject bala;
    public Transform puntoDisparo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala,puntoDisparo.position,puntoDisparo.rotation);
        }
    }
}
