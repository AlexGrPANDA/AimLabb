// Interactable script - used to distingiush interactables by adding a prompt msg changable in the scene
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    //message displayed when looking at a interactable
    public string promptMessage;
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {

    }
    
    
}
