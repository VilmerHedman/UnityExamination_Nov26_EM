using UnityEngine;

public class RandomPitchSound : MonoBehaviour
{
    public AudioClip soundClip;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.clip = soundClip;
    }

    public void PlayRandomPitch()
    {
        float pitchVariance = 0.5f; // ±5% from normal pitch
        float randomPitch = Random.Range(1f - pitchVariance, 1f + pitchVariance);
        audioSource.pitch = randomPitch;
        audioSource.PlayOneShot(soundClip);
    }
}