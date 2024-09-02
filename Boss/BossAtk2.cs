using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAtk2 : BossState
{
    public override void EnterState(BossStateMachine boss)
    {
        Debug.Log("Atk2");
    }

    public override void UpdateState(BossStateMachine boss)
    {

    }

    public override void OnCollisionEnter(BossStateMachine boss)
    {

    }
}
