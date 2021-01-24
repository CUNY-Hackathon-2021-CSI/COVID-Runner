using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;


public class SoundEffects : MonoBehaviour
{
    PlatformerCharacter2D playerControls;
    AudioSource soundFX;
    //public sound clips
    public AudioClip crate;
    public AudioClip badBox;
    public AudioClip goodBox;
    public AudioClip guy;
    public AudioClip jump;

    private void Start()
    {
        soundFX = this.GetComponent<AudioSource>();
        playerControls = GameObject.FindGameObjectWithTag("Player").GetComponent<PlatformerCharacter2D>();
    }

    private void Update()
    {
        //play jump sound on jump (space key)
        if (Input.GetKeyDown(KeyCode.Space) && playerControls.m_Grounded == true)
        {
            soundFX.clip = jump;
            soundFX.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //play appropriate clip on collision
        if (other.tag == "Crate")
        {
            soundFX.clip = crate;
            soundFX.Play();

        }
        else if (other.tag == "BadBox")
        {
            soundFX.clip = badBox;
            soundFX.Play();

        }
        else if (other.tag == "GoodBox")
        {
            soundFX.clip = goodBox;
            soundFX.Play();
        }
        else if (other.tag == "Guy")
        {
            soundFX.clip = guy;
            soundFX.Play();
        }
    }
}
