using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;
using Unity.VisualScripting;

[System.Serializable]
public class ScorchingFireState : SimpleState
{
    public GameObject magicObject;
    public GameObject magicBullet;
    public GameObject magicWand;
    public float cooldown = 1.0f;
    private Vector3 targetRotation;
    private Vector3 beginningRotation;
    private float time;

    // Start is called before the first frame update
   public override void OnStart()
    {
        time = 0.0f;
        
        if (magicObject == false)
            return;
    
        GameObject.Instantiate(magicBullet, magicObject.transform.position, magicObject.transform.rotation);
        magicWand.GetComponent<Animator>().Play("MagicWand");
        
    }

    // Update is called once per frame
   public override void UpdateState(float _dt)
    {
        // if (magicWand == false)
            //return;
        
        time += _dt;

        if (time > cooldown)
            stateMachine.ChangeState("IdleState");   
    }

    public override void OnExit()
    {

    }
}
