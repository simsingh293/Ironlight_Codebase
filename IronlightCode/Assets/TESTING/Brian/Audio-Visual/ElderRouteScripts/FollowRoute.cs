﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRoute : MonoBehaviour
{
    [SerializeField]
    private Transform[] Routes;
    private int routeToGo;
    private float param;
    private Vector3 ElderPos;
    public float speed;
    private bool CanCour;
    bool waitForPlayer;
    bool elderFinish;
    bool elderMove;
    public GameObject ElderHome;

    Vector3 currScale;
    Vector3 SmallScale = new Vector3(0.1f, 0.1f, 0.1f);
    // Start is called before the first frame update
    void Start()
    {
        routeToGo = 0;
        param = 0;
        //speed = 1;
        CanCour = true;
        waitForPlayer = true;
        currScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanCour&& !waitForPlayer)
        {
            StartCoroutine(MovePath(routeToGo));
        }
        else
        {
            StopCoroutine(MovePath(routeToGo));
        }
        ElderFinish();
    }
    private IEnumerator MovePath(int routeNum)
    {
        CanCour = false;
        Vector3 p0 = Routes[routeNum].GetChild(0).position;
        Vector3 p1 = Routes[routeNum].GetChild(1).position;
        Vector3 p2 = Routes[routeNum].GetChild(2).position;
        Vector3 p3 = Routes[routeNum].GetChild(3).position;
        while(param < 1)
        {
            param += Time.deltaTime * speed;
            ElderPos = Mathf.Pow(1 - param, 3) * p0 + 3 * Mathf.Pow(1 - param, 2) * param * p1 + 3 * (1 - param) * Mathf.Pow(param, 2) * p2 + Mathf.Pow(param, 3) * p3;
            transform.position = ElderPos;
            yield return new WaitForEndOfFrame();
        }
        param = 0;
        routeToGo++;
        if (routeToGo > Routes.Length - 1)
        {
            elderFinish = true;
        }
        CanCour = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            waitForPlayer = false;
            if (elderFinish)
            {
                elderMove = true;
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            waitForPlayer = true;
        }
    }
    void ElderFinish()
    {
        if (elderFinish&& elderMove)
        {
            transform.LookAt(ElderHome.transform.position);
            transform.Translate(transform.forward * Time.deltaTime);
            currScale -= new Vector3(0.1f, 0.1f, 0.1f) * Time.deltaTime;
            ReduceElderScale();

        }
    }
    void ReduceElderScale()
    {

        if(currScale == SmallScale)
        {
            Destroy(gameObject);
        }
    }
}
