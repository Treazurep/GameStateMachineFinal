using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;
using SuperPupSystems.Helper;
using Unity.VisualScripting;

[System.Serializable]
public class HealingState : SimpleState
{
    public GameObject healingObject;
    public float cooldown = 1.0f;

    private Vector3 targetRotation;
    private Vector3 beginningRotation;
    private float time;
    private TargetingSystem targetingSystem;
    private GameObject target;
    

    public override void OnStart()
    {
        time = 0.0f;
        
        healingObject = stateMachine.gameObject;
        targetingSystem = healingObject.GetComponent<TargetingSystem>();

        target = targetingSystem.FindTargetToHeal();

        if (target == false)
        {
            return;
        }

        Health health = target.GetComponent<Health>();

        if (health)
        {
            health.Heal(10);
        }
        
    }

    // Update is called once per frame
    public override void UpdateState(float _dt)
    {
        time += _dt;
        

        if (time > cooldown)
            stateMachine.ChangeState("IdleState");
    }

    public override void OnExit()
    {

    }
}
