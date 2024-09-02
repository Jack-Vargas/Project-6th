using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class PlaceMent : MonoBehaviour
{
    public GameObject PlaceableObjectPrefab;
    public GameObject CurrentPlaceableObject;
    public float mouseWheelRotation;
    public float checkSize;

    // Update is called once per frame
    void Update()
    {

        Prepare();

        if (CurrentPlaceableObject != null)
        {
            MoveToMouse();
            RoatateToMouse();
            Release();
        }

    }

    public void Prepare() 
    {
       if (Input.GetKeyDown(KeyCode.G))
        {
            if (CurrentPlaceableObject != null)// i dont know what this dose
            {
                Destroy(CurrentPlaceableObject);
            }

            else
            {
                CurrentPlaceableObject = Instantiate(PlaceableObjectPrefab);
            }
        }
    }

    public void MoveToMouse()
    {
        CurrentPlaceableObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 1f);
    }

    public void RoatateToMouse()
    {
        Debug.Log(Input.mouseScrollDelta);
        mouseWheelRotation += Input.mouseScrollDelta.y;
        CurrentPlaceableObject.transform.Rotate(Vector3.up, mouseWheelRotation * 10f);
    }

    public void Release()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D[] Obstructor = Physics2D.OverlapCircleAll(CurrentPlaceableObject.transform.position, checkSize);
            if (Obstructor.Length > 1)
            {
                Debug.Log("can't Place there");
            }
            else
            { 
                CurrentPlaceableObject = null;
            }
        }
    }

 
}
