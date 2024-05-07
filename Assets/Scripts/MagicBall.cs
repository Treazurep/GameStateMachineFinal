using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : MonoBehaviour
{
    private GameObject target;
    public ParticleSystem particleSystem;

    void Start()
    {
        // If TargetingSystem is found call FindTarget
        target = gameObject.GetComponent<TargetingSystem>()?.FindTarget();

        if (target)
            gameObject.transform.LookAt(target.transform);
        particleSystem.Play();
    }

    void Update()
    {
        if (target)
            gameObject.transform.LookAt(target.transform);
    }
}
