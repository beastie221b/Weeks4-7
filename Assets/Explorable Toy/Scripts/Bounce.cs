using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bounce : MonoBehaviour
{
    public GameObject barrel;
    public TextMeshProUGUI bounce;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update the bounce text per cannon ball
        CountBounce count = barrel.GetComponent<CountBounce>();
        bounce.text = count.bounce.ToString();
    }
}
