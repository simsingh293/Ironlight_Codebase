﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointSphere : MonoBehaviour
{
   public GameObject systemGo;
    public GameObject Effect;
    private bool Flag;

    public AudioSource sound;
    public AudioClip soundToPlay;
    public float volume;
    bool clipPlayed = false;
    private void OnTriggerEnter(Collider other)
   {
        Debug.Log("Touched It = " + other.tag );
        if (other.gameObject.CompareTag("Player"))
       {


            if (!Flag)
            {
            Instantiate(Effect, this.transform.position, this.transform.rotation);
                Flag = true;
            }
            systemGo.GetComponent<RespawnCheckPoint>().lastCheckPoint = this.transform;
            if (!clipPlayed)
            {
                sound.PlayOneShot(soundToPlay, volume);
                clipPlayed = true;
            }

        }
   }
}
