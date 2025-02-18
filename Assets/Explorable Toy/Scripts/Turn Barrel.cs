using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBarrel : MonoBehaviour
{
    // Set up and initialize the variable for the barrel's angle.
    public float angle = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // change the angle based on the value of the slider.
        Quaternion rotate = transform.rotation;
        rotate.z = angle;
        transform.rotation = rotate;
    }

    // allow slider to change angles.
    public void rotate(float a)
    {
        angle = a;
    }
}
