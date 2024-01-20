using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// test git
public class Barriar : MonoBehaviour {

    public AudioClip hitAudio;


    public void PlayAudio()
    {
        AudioSource.PlayClipAtPoint(hitAudio, transform.position);
    }
}
