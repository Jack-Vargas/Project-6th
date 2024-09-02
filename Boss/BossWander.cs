using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BossWander : BossState
{
    public Boss script;
    public GameObject TheBoss;
    public Transform walkPoint;
    public Rigidbody2D rb2D;
    public float wSpeed = 2; //WanderSpeed

    public override void EnterState(BossStateMachine boss)
    {
        TheBoss = boss.TheBoss;
        script = TheBoss.GetComponent<Boss>();
        rb2D = TheBoss.GetComponent<Rigidbody2D>();
        script.StartCoroutine(Wander(boss));      
    }

    public override void UpdateState(BossStateMachine boss)
    {
        
    }

    public override void OnCollisionEnter(BossStateMachine boss)
    {

    }

    public IEnumerator Wander(BossStateMachine boss)
    {
        float randNumA = Random.Range(0f, 2f);
        int randPosA = Random.Range(-1, 1);
        while (randPosA == 0)
        {
            randPosA = Random.Range(-1, 1);
        }

        int randPosB = Random.Range(-1, 1);
        while (randPosB == 0)
        {
            randPosB = Random.Range(-1, 1);
        }

        rb2D.velocity = new Vector3(randNumA * randPosA, (wSpeed - randNumA) * randPosB, 0); // ok so the idea is that wSpeed is the max speed and its devided up amongst x and y 

        yield return new WaitForSeconds(2f);

        int randNum = Random.Range(0, 1);

        rb2D.velocity = new Vector3(0, 0, 0);

        if (randNum < 0)
        {
            boss.SwitchState(boss.RunState);
        }
        else
        {
            boss.SwitchState(boss.Atk2State);
        }
    }
}
