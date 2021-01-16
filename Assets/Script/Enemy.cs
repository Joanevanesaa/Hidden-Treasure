using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject gameOverScreen;

    public static bool isGameOver = false;
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag.Equals("Player"))
        {
            Destroy(col.gameObject);
            gameOverScreen.SetActive(true);
            isGameOver = true;
            Destroy(gameObject);
        }
    }




}
