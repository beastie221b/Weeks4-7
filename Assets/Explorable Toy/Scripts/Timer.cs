using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider refill;
    public GameObject barrel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Update time base on barrel timer
        FireCannon fireCannon = barrel.GetComponent<FireCannon>();
        refill.value = fireCannon.time;
    }
}
