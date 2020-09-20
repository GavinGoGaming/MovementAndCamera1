using UnityEngine;

public class CameraCanMove : MonoBehaviour
{

    public Transform PlayerXYZ;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerXYZ.transform.position + offset;
    }
}
