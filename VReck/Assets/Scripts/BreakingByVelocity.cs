using UnityEngine;

public class BreakingByVelocity : MonoBehaviour
{
    [SerializeField] GameObject brokenObject;
    [SerializeField] float velocityThreshold;
    AudioSource sound;
    Rigidbody rb;

    bool isDestroyed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rb.angularVelocity.magnitude);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > velocityThreshold)
        {
            if(isDestroyed == false)
            {
                sound.Play();
                Destroy(gameObject);
                Instantiate(brokenObject, transform.position, transform.rotation * Quaternion.Euler(90, 0, 0)); 
                isDestroyed = true;
            }
        }
    }
}
