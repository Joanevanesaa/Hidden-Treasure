﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
       health = 150;    
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;
        Changehealth();
    }

    void Changehealth()
    {
        
    }
}
