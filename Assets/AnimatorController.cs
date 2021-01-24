using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    
    AudioSource soundFX;    
    private Animator animTarget;
    private Animator animOther;
    
    //public sound clips
    public AudioClip damage;

    void Start()
    {
        animTarget = GetComponent<Animator>();
        soundFX = this.GetComponent<AudioSource>();
    }    

    private void OnCollisionEnter2D(Collision2D other)
    {
        //play appropriate animation on collision
        if (other.gameObject.tag == "BadBox")
        {
            animTarget.SetBool("badCollision", true);
            animOther = other.gameObject.GetComponent<Animator>();
            animOther.SetBool("badCollision", true);
            soundFX.clip = damage;
            soundFX.Play();
        }
        else if(other.gameObject.tag == "Guy")
        {
            animTarget.SetBool("badCollision", true);
            animOther = other.gameObject.GetComponent<Animator>();
            animOther.SetBool("badCollision", true);
            soundFX.clip = damage;
            soundFX.Play();
        }        

    }


    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "BadBox")
        {
            animTarget.SetBool("badCollision", false);
            animOther = other.gameObject.GetComponent<Animator>();
            animOther.SetBool("badCollision", false);
        }
        else if (other.gameObject.tag == "Guy")
        {
            animTarget.SetBool("badCollision", false);
            animOther = other.gameObject.GetComponent<Animator>();
            animOther.SetBool("badCollision", false);
        }
    }


}
