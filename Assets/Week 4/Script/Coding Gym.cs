using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CodingGym : MonoBehaviour
{
    private float health = 100f;
    public TextMeshProUGUI Health;
    void Start()
    {
        Health.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            health -= 10;
            Health.text = health.ToString();
        }
    }
}
