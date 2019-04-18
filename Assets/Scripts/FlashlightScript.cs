using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    [SerializeField]
    private GameObject playerLight;

    [SerializeField]
    private bool isOn;

    private new Light light;
    // Start is called before the first frame update

    private void Start()
    {
        light = playerLight.GetComponent<Light>();
        isOn = false;
    }

    private void Update()
    {
        if(Input.GetButtonDown("Flashlight"))
        {
            isOn = !isOn;
        }
        if (isOn == true)
        {
            light.enabled = true;
        }
        else
        {
            light.enabled = false;
        }
    }
}
