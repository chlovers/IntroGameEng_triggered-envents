using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Playables;

public class Timelinestuff : MonoBehaviour
{
    public PlayableDirector timeline;



    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();

    }


}