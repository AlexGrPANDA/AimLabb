//MoreTargets - Interactable script where a target is spawned when keypad is interacted with
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreTargets : Interactable
{
    public GameObject Targets;
    public TargetBoundary Boundary;
    public GameObject Keypad;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        Debug.Log("Interacted Target");
        Instantiate(Targets, Boundary.GetRandomPos(), Quaternion.identity);
       
    }

}

