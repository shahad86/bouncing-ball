using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private float fixedY;
    private float offsetZ;

    void Start()
    {
        fixedY = transform.position.y;
        offsetZ = transform.position.z - target.position.z;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = new Vector3(target.position.x, fixedY, offsetZ);
        }
    }
}