﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using EZCameraShake;

public class Owl_WindAttackState : ImanBaseState
{
    Owl_StateManager stateManager;

    private Vector3 WindPlayerPos;
    private Vector3 direction;
    private RaycastHit hit;

    private float timer;

    public Owl_WindAttackState(Owl_StateManager _Manager) : base(_Manager.gameObject)
    {
        stateManager = _Manager;
    }

    public override void OnEnter()
    {
        Debug.Log("Entering Wind Attack State");
        calculateWindAttackPositions();
        timer = Time.time + stateManager.WindAttackDuration;
    }

    public override void OnExit()
    {
        Debug.Log("Exiting Wind Choose State");

    }

    public override Type Tick()
    {
        direction = WindPlayerPos - stateManager.transform.position;
        stateManager.transform.rotation = Quaternion.Slerp(stateManager.transform.rotation, Quaternion.LookRotation(direction), stateManager.SweepRotateSpeed * Time.deltaTime);
        if(Physics.SphereCast(stateManager.transform.position, stateManager.SphereRadius, direction.normalized , out hit, stateManager.MaxRange, stateManager.Windinteractable))
        {
            if(hit.transform.gameObject.CompareTag("Player"))
            {
                var owl = stateManager.transform.position;
                owl.y = stateManager.PLY_Transform.position.y;
                var dir = stateManager.PLY_Transform.position - owl;
                hit.transform.gameObject.GetComponent<Rigidbody>().AddForce(stateManager.WindForce * dir, ForceMode.Force);
                //shake camera while wind hitting the player
                //CameraShaker.Instance.ShakeOnce(5.0f, 10.0f, 0.5f, 0.5f);
                Debug.Log("HittinPlayer");
            }
        }
        else
        {

        }

        if (timer < Time.time)
        {
            stateManager.OwlAnim.SetBool("Wind", false);
            stateManager.WindAttack = false;
            stateManager.StartCoroutine("SlowRotation");
            return typeof(Owl_ChooseAttackState);
        }

        return null;
    }

    private void calculateWindAttackPositions()
    {
        //PlayerPos
        WindPlayerPos = stateManager.PLY_Transform.position;
    }
}
