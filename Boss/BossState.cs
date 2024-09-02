using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class BossState
{
    //notice this dose'nt use monobehaviour and has the word abstract before the class

    public abstract void EnterState(BossStateMachine boss);

    public abstract void UpdateState(BossStateMachine boss);

    public abstract void OnCollisionEnter(BossStateMachine boss);

    





}
