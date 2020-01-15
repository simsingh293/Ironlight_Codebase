﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLY_2ndBulletOrb : MonoBehaviour
{
    //bullet components
    private bool Moving;
    [SerializeField] private int _iDisableTimer;
    [SerializeField] private int _iSpeed;
    [SerializeField] private int _iDamageAmount;
    [SerializeField] [Range(0, 1)] private float PushOnColDirToVelocityRatio = 1;
    private Rigidbody rigid;

    //explosion
    [SerializeField] private int _iExplosionDmg;
    private GameObject _goCollidedObject;
    [SerializeField] private int _iExplosionSphereRadius;

    //seek
    public GameObject EnemyToChase;
    [SerializeField] private float SeekRotateSpeed = 5;
    [SerializeField] private LayerMask enemyLayer;
    [SerializeField] private float targettedRadius = 2;
    [SerializeField] private float nonTargettedRadius = 1;
    [SerializeField] private float MaxSeekEnemyRange = 20;


    public void StartOrb(Vector3 pDir)
    {

        //activate bullet
        gameObject.SetActive(true);

        transform.forward = pDir;

        rigid = GetComponent<Rigidbody>();

        Moving = true;

        //deactivate after 5 seconds
        StartCoroutine("BulletDisable");
    }

    public void EnemyToSeek(GameObject closestEnemy)
    {
        if(closestEnemy != null)
        {
            EnemyToChase = closestEnemy;
        }
    }

    private void Update()
    {
        SeekEnemy();
        if (EnemyToChase != null)
        {
            Vector3 direction = EnemyToChase.transform.position - transform.position;
            gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * SeekRotateSpeed);



            //rigid.velocity = direction.normalized * _iSpeed * Time.deltaTime;

            print("chasing " + EnemyToChase);
        }
        if(Moving)
        {
            transform.position +=transform.forward * _iSpeed * Time.deltaTime;
        }
    }

    float hitdis;
    private void SeekEnemy()
    {
        float radius = 0;

        if(EnemyToChase != null)
        {
            radius = targettedRadius;
        }
        else
        {
            radius = nonTargettedRadius;
        }

        RaycastHit hit;
        //create a spherecast to see whats infront of the player
        if (Physics.SphereCast(transform.position, radius, transform.forward, out hit, MaxSeekEnemyRange, enemyLayer))
        {
            EnemyToChase = hit.transform.gameObject;
            hitdis = hit.distance;

        }
        else
        {
            EnemyToChase = null;
        }
    }

    private void Explosion()
    {
        //get all colliders in the sphere
        foreach (Collider pcollider in Physics.OverlapSphere(transform.position, _iExplosionSphereRadius))
        {

            IAttributes cIA = pcollider.gameObject.GetComponent<IAttributes>();
            //check if gameobject is damagable
            if (cIA != null)
            {
                //if gameobject is not the collided game object to avoid damaging twice
                if (_goCollidedObject != pcollider.gameObject)
                    cIA.TakeDamage(_iExplosionDmg, false);
            }
        }
    }
    IEnumerator BulletDisable()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(_iDisableTimer);
        gameObject.SetActive(false);

        //set velocity to 0
        rigid.velocity = Vector3.zero;

        EnemyToChase = null;
    }

    private void Collided()
    {
        //Explosion
        Explosion();

        //deactivate object
        gameObject.SetActive(false);

        //set velocity to 0
        rigid.velocity = Vector3.zero;

        //set chasing enemy to null
        EnemyToChase = null;

        //stop 
        StopCoroutine("BulletDisable");
    }

    private Vector3 calcPushBackDir(GameObject enemy)
    {
        //calculate direction based on where enemy hit the player
        Vector3 dirRatio = ((enemy.gameObject.transform.position - transform.position).normalized * PushOnColDirToVelocityRatio);
        //calculate direction based on players movement direction
        Vector3 VelocityRatio = (rigid.velocity.normalized * (1 - PushOnColDirToVelocityRatio));
        //add the 2 ratios together
        return dirRatio + VelocityRatio;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if collided object has IAtributes do damage
        if (collision.gameObject.GetComponent<IAttributes>() != null)
        {
            collision.gameObject.GetComponent<IAttributes>().TakeDamage(_iDamageAmount, false);
            _goCollidedObject = collision.gameObject;
        }

        Collided();
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position, transform.position + transform.forward * hitdis);
        Gizmos.DrawWireSphere(transform.position + transform.forward * hitdis, 4);
    }
    
}