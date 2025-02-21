using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    AudioSource audio;
    SpriteRenderer spriteRenderer;

    public AudioClip[] audioClips;

    private void Start()
    {
        audio = GetComponent<AudioSource>();    
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            //audio.Play();
            // audio.Stop();
            // audio.loop = true;
            

            int randomNumber = Random.Range(0, audioClips.Length);
            if (audio.isPlaying)
            {
                audio.PlayOneShot(audioClips[randomNumber]);
            }
        }
    }
}
