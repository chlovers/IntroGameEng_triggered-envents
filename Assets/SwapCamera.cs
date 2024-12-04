using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    public GameObject camera_main;
    public GameObject camera_right;
    public GameObject doll;

    void OnTriggerEnter(Collider other)
    {
        
       
            camera_main.SetActive(false);
            camera_right.SetActive(true);
        doll.SetActive(false);
    }
}
