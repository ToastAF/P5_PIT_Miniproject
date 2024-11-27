using System.Collections;
using UnityEngine;

public class DestroySelfAfterSeconds : MonoBehaviour
{
    [SerializeField] float seconds;
    AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        StartCoroutine(DestroySelf(seconds));
    }

    IEnumerator DestroySelf(float sec)
    {
        sound.Play();
        yield return new WaitForSeconds(sec);
        Destroy(gameObject);
    }
}
