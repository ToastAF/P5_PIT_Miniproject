using UnityEngine;

public class PlaySoundWhenTouchj : MonoBehaviour
{
    [SerializeField] AudioSource sound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
        {
            sound.Play();
        }

    }
}
