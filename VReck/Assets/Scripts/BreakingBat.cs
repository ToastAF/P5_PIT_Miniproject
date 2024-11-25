using System;
using System.Collections;
using UnityEngine;

public class BreakingBat: MonoBehaviour
{
    [SerializeField] private GameObject brokenBatPrefab;
    [SerializeField] private int durabilityCount = 25;
    [SerializeField] private float iFrameTime = 1.5f;
    [SerializeField] private float velocityThreshold = 5.0f;

    private Rigidbody rb;
    private bool isInvulnerable = false;
    private bool isBroken = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isBroken || isInvulnerable) return;

        if (collision.relativeVelocity.magnitude < velocityThreshold) return;

        durabilityCount--;

        StartCoroutine(IFrameCD());

        if (durabilityCount <= 0)
        {
            BreakBat();
        }
    }

    void BreakBat()
    {
        isBroken = true;
        
        Destroy(gameObject);

        GameObject brokenBat = Instantiate(brokenBatPrefab, transform.position, transform.rotation);

        Rigidbody brokenBatRB = brokenBat.GetComponent<Rigidbody>();

        if (brokenBat != null)
        {
            brokenBatRB.angularVelocity = rb.angularVelocity;
        }
    }

    private IEnumerator IFrameCD()
    {
        isInvulnerable = true;
        yield return new WaitForSeconds(iFrameTime);
        isInvulnerable = false;
    }
}

