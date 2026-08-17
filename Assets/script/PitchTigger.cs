using UnityEngine;

public class PitchAudio : MonoBehaviour
{
    public AudioSource stadiumAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            stadiumAudio.Play();
        }
    }
}