using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Playables;

public class Timelinestuff : MonoBehaviour
{
    public PlayableDirector timeline;
    private bool played;

    private void Start()
    {
        played = false;
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if(played == false)
        {
            timeline.Play();
            played = true;
        }
        
        

    }


}