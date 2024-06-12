// RemoveTxt - Keypad Script that removes certain texts around the map
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTxts : Interactable
{ 
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
        GameObject[] Rtxt = GameObject.FindGameObjectsWithTag("Rtxt");
        foreach (GameObject Removable in Rtxt)
            GameObject.Destroy(Removable);
    }
}
