using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour
{
    // Cannon ball prefeb 
    public GameObject cannonBall;
    public float time;
    // Reload for 5 seconds
    float reload_time = 2f;
    bool fired = false;
    void Start()
    {
        time = reload_time;
    }

    // Update is called once per frame
    void Update()
    {
        // fire the ball when button is clicked
        if (fired)
        {
           GameObject newCannonBall = Instantiate(cannonBall, transform.position, transform.rotation);
           CannonBall ball = newCannonBall.GetComponent<CannonBall>();
            ball.parent = gameObject;
        }
        // Reload the cannon ball
        if (time < reload_time)
        {
            time += Time.deltaTime;
        }
        // Reset fired
        fired = false;
    }

    // A function to trigger fire
    public void fire()
    {
        // If reload is completed
        if (time >= reload_time)
        {
            fired = true;
            time = 0;
        }
    }
}
