using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HifFireMan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = other.transform.position;
        }
    }
}
