﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sharmout.SO;

namespace Danish
{
    [RequireComponent
        (typeof(Rigidbody), 
        typeof(Tools.dObjectPooler), 
        typeof(StateCode.dInputHandler)
        
    )]
    public class StateController : MonoBehaviour
    {
        public Vector3 playerVelocity = Vector3.zero;

        [Header("Movement Speeds")]
        public float forwardSpeed = 1f;
        public float backwardSpeed = 1f;
        public float straffeSpeed = 1f;
        public float generalSpeed = 5f;

        public Rigidbody parentRigidbody = null;
        public Animator parentAnimator = null;
        public Tools.dObjectPooler parentPooler = null;
        public StateCode.dInputHandler parentInput = null;
        public LineRenderer parentLine = null;
        [SerializeField]
        public StateCode.dStateManager parentManager = null;

        public Transform parentCamera = null;
        public Transform parentMuzzle = null;

        public Danish.Components.dUpdateMuzzleRotation muzzleRotator = null;

        public BeamSO beamStats = null;
        public BlastSO blastStats = null;
        public OrbSO orbStats = null;

        private void Reset()
        {
            parentRigidbody = GetComponent<Rigidbody>();
            parentRigidbody.useGravity = false;
            parentRigidbody.constraints = RigidbodyConstraints.FreezeRotation;

            parentPooler = GetComponent<Tools.dObjectPooler>();

            parentInput = GetComponent<StateCode.dInputHandler>();
        }

        private void Awake()
        {
            parentManager = parentInput.Init();

            parentManager?.AttackStatInit(orbStats, beamStats, blastStats);
            parentManager?.Init(gameObject, parentRigidbody, parentPooler, parentAnimator, parentCamera, parentMuzzle);

            muzzleRotator = new Components.dUpdateMuzzleRotation();
            muzzleRotator.Init(transform, parentMuzzle);
        }

        void Start()
        {

        }

        void Update()
        {
            parentManager.Tick();
            muzzleRotator.Tick();
            //playerVelocity = parentRigidbody.velocity;
        }

        private void FixedUpdate()
        {
            parentManager.FixedTick();
        }


        void UpdateFixedValues()
        {

        }
    }
}