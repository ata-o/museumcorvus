using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorSound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    private Animator anim;
    private float PlayDuration;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        PlayDuration = SoundToPlay.length;
            
    }

    void OnTriggerEnter()
    {
        
        StartCoroutine(Wait());
            
    
    }

    IEnumerator Wait()
    {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
            anim.SetBool("isTalking", true);


        }
        yield return new WaitForSeconds(PlayDuration);
        anim.SetBool("isTalking", false);
        audio.Stop();
    }



}
