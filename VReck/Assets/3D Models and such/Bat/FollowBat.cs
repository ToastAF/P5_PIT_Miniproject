using UnityEngine;

public class FollowBat : MonoBehaviour
{
    [SerializeField] GameObject followPoint;

    private void Update()
    {
        transform.position = followPoint.transform.position;
        transform.rotation = followPoint.transform.rotation;
    }
}
