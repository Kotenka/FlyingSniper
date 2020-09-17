using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class TrashSound : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Music()
    {
        audioSource.PlayOneShot(audioClip, 0.7F);
    }
}
