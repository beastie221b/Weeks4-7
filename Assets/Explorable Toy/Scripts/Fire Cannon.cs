using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour
{
    // Cannon ball prefeb 
    public GameObject cannonBall;
    bool fired = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // fire the ball when button is clicked
        if (fired)
        {
            Instantiate(cannonBall, transform.position, transform.rotation);
        }
        // reset fired
        fired = false;
    }

    // A function to trigger fire
    public void fire()
    {
        fired = true;
    }
}
