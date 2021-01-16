using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public static float health;
    public GameObject GameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
       health = 150;    
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;
        ChangeHealth();
    }

    public void ChangeHealth()
    {
        if (health <= 0)
        {
            GameOverScreen.SetActive(true);
            Enemy.isGameOver = true;
        }
    }

 
    
}
