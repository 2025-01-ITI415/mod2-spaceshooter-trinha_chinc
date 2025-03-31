using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource SFXSource;
    public AudioClip background;
    public AudioClip powerup;
    public AudioClip shoot;
    public AudioClip damaged;
    public AudioClip select;



    public void Start(){
        musicSource.clip = background;
        musicSource.Play();

    }

    public void PlaySFX(AudioClip clip){
        if (!SFXSource.isPlaying) // Prevents overlapping sounds
        {
            SFXSource.PlayOneShot(clip);
        }
    }

    // public void Button3(){
    //     src.clip = sfx3;
    //     src.Play();
    // }
}
