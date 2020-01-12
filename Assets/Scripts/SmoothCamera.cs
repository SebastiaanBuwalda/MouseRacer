using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float smoothTime;
    [SerializeField]
    private Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    [SerializeField]
    private float rotationSpeed;


    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime * Time.deltaTime);
        transform.position = smoothedPosition;
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationSpeed * Time.deltaTime);
    }
}
