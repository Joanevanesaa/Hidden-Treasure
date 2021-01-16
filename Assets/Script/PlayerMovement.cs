using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
	public float ms = 25;


    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	
        float horiz = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");

        print(HealthBar.health);

        if (horiz != 0  || verti !=0)
        {
            HealthBar.health -= 0.09f;
        }
        else
        {
            if(HealthBar.health < 150)
                HealthBar.health += 0.07f;
        }

        
        Rb.velocity = new Vector2(ms * horiz, verti * ms);
    }
}
