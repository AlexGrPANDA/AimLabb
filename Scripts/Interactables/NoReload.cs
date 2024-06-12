// NoReload - Keypad Script which when interacted with repeats the bullet count to be the same removing the aspect of reloading hence no reload
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoReload : Interactable
{
    public GunData Bullets;
    public GameObject Keypad;
    bool NoRe = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (NoRe)
        {
            Bullets.currentAmmo = 15;
        }
    }
    protected override void Interact()
    {
        Debug.Log("Interacted Reload");
        if (NoRe)
        {
            NoRe = false;
        }
        else
        {
            NoRe = true;
        }
    }
    
}
