using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTriggerRoom : MonoBehaviour
{

    public string cameraToSwitch;
    private bool estaIndo;
    private Animator camAnimator;

    private void Start()
    {
        camAnimator = GameObject.FindGameObjectWithTag("camAnimator").GetComponent<Animator>();
        estaIndo = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (estaIndo)
        {
            estaIndo = false;
            camAnimator.SetBool(cameraToSwitch, estaIndo);
        }
        else
        {
            estaIndo = true;
            camAnimator.SetBool(cameraToSwitch, estaIndo);
        }
        
    }
}
