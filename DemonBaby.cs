using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonBaby : MonoBehaviour
{
    public Transform goal;
    public GameObject player;
    public Transform babyTransform;
    public Vector3 Offset;
    private float Speed;
    public float fastDistance;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        goal.position = player.transform.position + Offset;
        float directionToPlayer = Vector2.Distance(goal.position, babyTransform.position);

        if (directionToPlayer >= fastDistance)
        {
            Speed = 3;
        }
        else if (directionToPlayer < fastDistance)
        {
            Speed = 1.5f;
        }

        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, goal.position, Speed * Time.deltaTime);
    }
}
