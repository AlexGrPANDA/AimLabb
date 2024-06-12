//LessTargets - Interactable Script that deletes all Targets in the Game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessTargets : Interactable
{
    public GameObject Targets;
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
        GameObject[] TargetClones = GameObject.FindGameObjectsWithTag("TargetClone");
        foreach (GameObject Targets in TargetClones)
            GameObject.Destroy(Targets);
    }
    

}
