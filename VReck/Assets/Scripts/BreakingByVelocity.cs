using UnityEngine;

public class BreakingByVelocity : MonoBehaviour
{
    [SerializeField] GameObject brokenObject;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
            Instantiate(brokenObject, transform.position, transform.rotation * Quaternion.Euler(90, 0, 0));            
        }
    }
}
