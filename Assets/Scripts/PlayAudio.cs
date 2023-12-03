using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
  // Start is called before the first frame update  public AudioSource audioSource; // Reference to the AudioSource component
  public AudioSource audioSource; // Reference to the AudioSource component
  public AudioClip audioClip;     // The audio clip to play

  void Start()
  {
    // Assign the audio clip to the audio source
    audioSource.clip = audioClip;

    // Play the audio
    audioSource.Play();
    audioSource.loop = true;
  }

  public void playSound(Transform transform, AudioClip audioClip, float volume)
  {
    AudioSource.PlayClipAtPoint(audioClip, transform.position, volume);
  }

}
