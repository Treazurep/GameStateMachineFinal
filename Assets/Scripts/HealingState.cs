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


    public override void OnStart()
    {
        
    }

    // Update is called once per frame
    public override void UpdateState(float _dt)
    {
        
    }

    public override void OnExit()
    {

    }
}
