using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowExlamationOnNearby : MonoBehaviour
{
    public GameObject exclamationMark;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.GetComponent<Character>())
            return;
        
        exclamationMark.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.GetComponent<Character>())
            return;
        
        exclamationMark.SetActive(false);
        Main.singleton.dialogWindow.HideText();
    }
}
