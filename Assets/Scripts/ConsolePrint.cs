﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    int value = 0;

    // Start is called before the first frame update
    void Start()
    {
        value = 0;
    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log(gameObject.name + ": " + value);

        value++;
    }
}
