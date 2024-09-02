using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Vector3 Velo;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Velo = rb2D.velocity;
    }
}
