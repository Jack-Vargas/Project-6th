using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour
{
  public Vector3 MousePosition;
    public Vector3 hIPoint;

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;


        //if (hitInfo.collider)
        {
            //gameObject.transform.position = hitInfo.point;
            //hIPoint = hitInfo.point;
            
        }
        //gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f,0f,10f);

        MousePosition = Input.mousePosition;
    }
}
