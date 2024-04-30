using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;
public class ClericStateMachine : MonoBehaviour
{
    public IdleState idleState;
    public ChaseState chaseState;
    public HealingState healingState;


    void Awake()
    {
        //states.Add(idleState);

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
