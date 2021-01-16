using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShow : MonoBehaviour
{

    public GameObject enemy;

    void Update()
    {
        if(JumlahBatu.Jumlah >= 15 && Enemy.isGameOver == false)
        {
            enemy.SetActive(true);
        }
        else
        {
            enemy.SetActive(false);
        }
    }
   



}
