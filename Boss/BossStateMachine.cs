using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class BossStateMachine : MonoBehaviour
{
    public BossState currentState;
    public BossRun RunState = new BossRun();
    public BossAtk1 Atk1State = new BossAtk1();
    public BossAtk2 Atk2State = new BossAtk2();
    public BossWander WanderState = new BossWander();

    public GameObject TheBoss;

    private void Start()
    {
        TheBoss = gameObject;
        currentState = new BossWander();
        currentState.EnterState(this); // the "this" here is saying to use this for the argement requested by the enterstate funcion
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BossState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
