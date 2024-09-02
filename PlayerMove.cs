using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb2D;

    public float MoveForce = 5;


    void FixedUpdate()
    {

        float movehor = Input.GetAxis("Horizontal");

        rb2D.velocity = new Vector3(movehor * MoveForce, rb2D.velocity.y);

        float movevert = Input.GetAxis("Vertical");
        rb2D.velocity = new Vector3(rb2D.velocity.x, movevert * MoveForce);
    }
}
