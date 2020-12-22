using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batu : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag.Equals ("Player")) {
            Destroy(gameObject);
            JumlahBatu.Jumlah += 1;
        }
    }
}
