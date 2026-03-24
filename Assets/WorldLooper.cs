using UnityEngine;

public class WorldLooper : MonoBehaviour
{
    public Transform cameraTransform;

    public float groundWidth = 20f;

    void Update()
    {
        if (cameraTransform.position.x > transform.position.x + groundWidth)
        {
            transform.position = new Vector3(transform.position.x + groundWidth * 2, transform.position.y, transform.position.z);
        }
    }
}