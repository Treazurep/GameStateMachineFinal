using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;

public class MageStateMachine : SimpleStateMachine
{
    public IdleState idleState;
    public ChaseState chaseState;
    public ScorchingFireState scorchingFireState;
    void Awake()
    {
        states.Add(idleState);
        //states.Add(chaseState);
        states.Add(scorchingFireState);

        ChangeState(nameof(idleState));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
