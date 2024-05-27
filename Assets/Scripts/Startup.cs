using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startup : MonoBehaviour
{

    public Slider mouse_slider;

    private void Awake()
    {
        // Set Mouse Sensitivity
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().mouseSensitivity = PlayerPrefs.GetFloat("MouseSensitivity", 400f);

        mouse_slider.value = PlayerPrefs.GetFloat("MouseSensitivity", 400f);

    }
}
