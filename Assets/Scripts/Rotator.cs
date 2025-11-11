
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotateSpeed;
    public float Rot;
    void FixedUpdate()
    {
        Rot = Input.GetAxis("Horizontal") * RotateSpeed;
        //float angle = transform.eulerAngles.z;
        transform.Rotate(0, 0, Rot * -1f * Time.deltaTime);

    }
}