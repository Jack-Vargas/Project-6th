using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float spinSpeed;
    public Transform anchorPoint;
    public float spinDirection;
    

    void Update()
    {
        transform.RotateAround(anchorPoint.position, Vector3.forward, (spinSpeed * Time.deltaTime) * spinDirection);
        //spin direction is ment to be set at 1 or -1 to set the rotation to clockwise or counterclockwise
    }
}
