using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    // Initialize the value of moving speed for the canan ball.
    float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the canan ball in the moving speed.
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}

