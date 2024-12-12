using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = transform.position;

        //Flyttar kameran till spelarens position med en offset
        desiredPosition.x = player.position.x + offset.x;
        desiredPosition.z = -10;

        //Förlyttar kameran med spelaren med en "smooth" hastighet
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
