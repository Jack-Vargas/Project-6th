using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRun : BossState
{

    public float distance;
    public float speed = 4;
    public GameObject player;

    public override void EnterState(BossStateMachine boss)
    {
        Debug.Log("jermaVenus");

        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override void UpdateState(BossStateMachine boss)
    {
        float directionToPlayer = Vector2.Distance(player.transform.position, boss.TheBoss.transform.position);

        if (directionToPlayer < 2)
        {
            boss.SwitchState(boss.Atk1State);
        }

        boss.TheBoss.transform.position = Vector3.MoveTowards(boss.TheBoss.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    public override void OnCollisionEnter(BossStateMachine boss)
    {

    }
}
