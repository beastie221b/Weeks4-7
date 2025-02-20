using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    // Initialize the value of moving speed for the canan ball.
    float moveSpeed = 10f;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        // Destroy the cannon ball after 10 seconds.
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        // Get the sprite renderer component
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();

        // Move the canan ball in the moving speed.
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        // Get cannon ball screen position
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        // Destroy cannon ball if it flies out of the screen
        Vector3 rotation = transform.rotation.eulerAngles;

        // Set the random colour to cannon balls
        Color color = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
            );

        // Count the number of the bounce time
        CountBounce count = parent.GetComponent<CountBounce>();

        // Check if the cannon ball bounced on the wall
        if (screenPosition.x < 0 || screenPosition.x > Screen.width)
        {
            rotation.y += 180;
            renderer.color = color;
            count.bounce++;
        }
        if (screenPosition.y < 0 || screenPosition.y > Screen.height)
        {
            rotation.x += 180;
            renderer.color = color;
            count.bounce++;
        }
        transform.rotation = Quaternion.Euler(rotation);
    }
}

