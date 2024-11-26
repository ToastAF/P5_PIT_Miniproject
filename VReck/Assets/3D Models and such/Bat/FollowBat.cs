using UnityEngine;
using UnityEngine.XR;

public class FollowBat : MonoBehaviour
{
    [SerializeField] GameObject followPoint;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(followPoint.transform.position);
        rb.MoveRotation(followPoint.transform.rotation);
    }
}
