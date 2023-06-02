using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{
   
    public GameObject cutsceneTrigger;

    // Start is called before the first frame update
    private void OnTriggerEnter()
    {
        cutsceneTrigger.SetActive(true);
    }
}