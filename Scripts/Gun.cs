//Gun - Weapon Script that controls player shooting, reloading and keeps track of player ammo, it is also responsible for the raycast where the bullet comes from

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    
    [Header("References")]
    [SerializeField] private GunData gunData;
    [SerializeField] private Transform cam;
    [SerializeField] public TextMeshProUGUI AmmoDisplay;
    [SerializeField] public int Ammo;
    float timeSinceLastShot;

    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput += StartReload;

    }

    private void OnDisable() => gunData.reloading = false;

    public void StartReload()
    {
        Debug.Log("RELOADEDED");
        if (!gunData.reloading && this.gameObject.activeSelf)
            StartCoroutine(Reload());
        
    }

    private IEnumerator Reload()
    {
       
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = gunData.magSize;

        gunData.reloading = false;
        Debug.Log(gunData.currentAmmo);
    }

    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    private void Shoot()
    {
        Debug.Log("Shooting?");
        if (gunData.currentAmmo > 0)
        {
            if (CanShoot())
            {
                Debug.Log(gunData.currentAmmo);
                Debug.Log("Shot");
                if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                    damageable?.TakeDamage(gunData.damage);
                    Debug.Log(hitInfo.transform.name);
                }

                gunData.currentAmmo--;
                timeSinceLastShot = 0;
                OnGunShot();
               


            }
        }
    }

    private void Update()
    {
        Ammo = gunData.currentAmmo;
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(cam.position, cam.forward * gunData.maxDistance);
        AmmoDisplay.text = Ammo.ToString();
    }

    private void OnGunShot() { }


}