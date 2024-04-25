using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;

public class MageStateMachine : SimpleStateMachine
{
   public IdleState idlestate;
   public ChaseState chasestate;
   public ScorchingFireState scorchingFireState;
    void Awake()
    {
        states.Add(idleState);
        states.Add(chaseState);
        stats.Add(scorchingFireState);

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
