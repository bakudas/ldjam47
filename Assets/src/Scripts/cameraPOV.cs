using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPOV : MonoBehaviour
{

    public string cameraToSwitch;
    public bool estaQuebrada;
    private bool estaIndo;
    private Animator camAnimator;

    private void Start()
    {
        camAnimator = GameObject.FindGameObjectWithTag("camAnimator").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        camAnimator.SetBool(cameraToSwitch, true);
    }

    private void OnTriggerExit(Collider other)
    {
        camAnimator.SetBool(cameraToSwitch, false);
    }
}
