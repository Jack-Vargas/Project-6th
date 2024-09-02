using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlue : MonoBehaviour
{

    private float chargeTime;
    public float chargeSpeed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("GotKey");
            chargeTime = Time.time + 1f / chargeSpeed;      
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            if (Time.time > chargeTime)
            {
                ChargeShot();
            }
            else
            {
                NotChargeShot();
            }
        }
    }

    private void ChargeShot()
    {
        Debug.Log("big");
    }
    private void NotChargeShot()
    {
        Debug.Log("small");
    }
}
