using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterController : MonoBehaviour
{
    public GameObject Player;
    public FixedJoystick fixedJoystick;
    public float speed;
	
	// Start is called before the first frame update
    void Start()
    {
        speed = 25;
    }

    // Update is called once per frame
    void Update()
    {
        if (fixedJoystick.Vertical > 0) //up
        {
        	Player.transform.Translate(Vector2.up*Time.deltaTime*speed);
            HealthBar.health -= 0.09f;
        }
		else if (fixedJoystick.Vertical < 0) //down
        {
        	Player.transform.Translate(Vector2.down*Time.deltaTime*speed);
            HealthBar.health -= 0.09f;
        }
        
        if (fixedJoystick.Horizontal > 0) //right
        {
        	Player.transform.Translate(Vector2.right*Time.deltaTime*speed);
            HealthBar.health -= 0.09f;
        }
        else if (fixedJoystick.Horizontal < 0) //left
        {
        	Player.transform.Translate(Vector2.left*Time.deltaTime*speed);
            HealthBar.health -= 0.09f;
        }
    }
}
