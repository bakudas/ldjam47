using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPOV : MonoBehaviour
{

    public Animator camAnimator;

    private void Start()
    {
        camAnimator = GameObject.FindGameObjectWithTag("camAnimator").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        camAnimator.SetBool("camera3", true);
    }

    private void OnTriggerExit(Collider other)
    {
        camAnimator.SetBool("camera3", false);
    }
}
