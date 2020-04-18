using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialogOnClose : MonoBehaviour
{
    public GameObject exclamationMark;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        exclamationMark.SetActive(true);

        var triggerTalk = other.GetComponent<TriggerTalk>();
        if (triggerTalk) triggerTalk.readyToTalk = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        exclamationMark.SetActive(false);
        
        var triggerTalk = other.GetComponent<TriggerTalk>();
        if (triggerTalk) triggerTalk.readyToTalk = false;
    }
}
