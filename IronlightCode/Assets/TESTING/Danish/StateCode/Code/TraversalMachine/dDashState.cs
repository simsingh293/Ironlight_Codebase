﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Danish.Components;

namespace Danish.StateCode
{
    public class dDashState : dTraversalBaseState
    {
        private dStateManager Manager;
        private Rigidbody m_Rigid;

        private dDashComponent DashHandler = null;

        private bool isDashCompleted = false;


        private float dashCooldown = 0.05f;
        private float dashTimer = 0;

        public dDashState(dStateManager _stateManager) : base(_stateManager.obj)
        {
            base.MainManager = _stateManager;

            if(Manager != base.MainManager)
            {
                Manager = base.MainManager;
            }

            m_Rigid = Manager.rigidbody;

            DashHandler = Manager.dDash;
        }

        public override void OnEnter()
        {
            DashHandler.Init(Manager.objTransform.forward, m_Rigid);
        }

        public override void OnExit()
        {
            DashHandler.ResetAllValues();
            dashTimer = 0;
        }

        public override Type Tick()
        {
            Debug.Log("Dashing");

            if (Manager.isDashing)
            {
                Manager.isDashing = false;
                return typeof(dIdleState);
            }

            isDashCompleted = DashComplete();

            if (!isDashCompleted)
            {
                DashHandler.Tick();
            }
            else
            {
                return typeof(dIdleState);
            }

            return null;
        }


        public bool DashComplete()
        {
            if(dashTimer < dashCooldown)
            {
                dashTimer += Time.deltaTime;
                return false;
            }
            else
            {
                return true;
            }

        }

        public override void FixedTick()
        {
            throw new NotImplementedException();
        }
    }
}