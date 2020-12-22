using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombEffect : MonoBehaviour
{
    Text randomNamaBatu;

    void Start()
    {
        randomNamaBatu = GetComponent<Text>();
        RandomFromList();
        JumlahBatu.Jumlah += 5;

    }

    public void RandomFromList()
        {
        string[] stoneName = new string[] { "Coal", "Stone", "Silver", "Copper" };
        string randomStone = stoneName[Random.Range(0, stoneName.Length)];
        randomNamaBatu.text = randomStone;
 
    }

}
