using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumlahBatu : MonoBehaviour
{
    public static int Jumlah;
    Text HitungBatu;

    // Start is called before the first frame update
    void Start()
    {
        Jumlah = 1;
        HitungBatu = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HitungBatu.text = "Jumlah Batu: " + Jumlah.ToString();
    }
}
