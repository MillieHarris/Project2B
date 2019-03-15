using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 //Creating an audio source that a sound clip is attached to that will be used in a function to call the sound clip
    [Header("Audio")]
    public AudioClip ButtonSound;

    //Creating the function that calls the sound to be played using the audio source



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "penguin")
        {
            PlayOneShot(ButtonSound);

        }
    }

    private void PlayOneShot(AudioClip buttonSound)
    {
        throw new NotImplementedException();
    }
}