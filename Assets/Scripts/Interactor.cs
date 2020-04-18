using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public bool isInteracting;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        var talkable = other.GetComponent<SingleDialogTalker>();
        if (talkable)
        {
            talkable.ShowDialog();
            isInteracting = true;
        }
    }
}