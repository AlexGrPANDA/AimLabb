//PLayer look - Script that allows player to move their mouse to move the camera/screen
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public Slider slider;
    private float xRotation = 0f;
    [SerializeField] float mouseSensitivity = 1f;

    void Start()
    {
        mouseSensitivity = slider.value * mouseSensitivity;
        Cursor.visible = false;
        
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ProcessLook(Vector2 input)
    {
       
        float xSensitivity = 30 * mouseSensitivity;
    float ySensitivity = 30 * mouseSensitivity;
    float mouseX = input.x;
        float mouseY = input.y;
        //calculate camera rotation for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //applu this to our camera
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        // rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
        PlayerPrefs.SetFloat("currentSensitivity", mouseSensitivity);
    }
    public void AdjustSpeed(float newSpeed)
    {
        mouseSensitivity = newSpeed * 1;
    }

}