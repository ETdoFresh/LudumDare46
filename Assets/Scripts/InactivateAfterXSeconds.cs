using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactivateAfterXSeconds : MonoBehaviour
{
    public float inactivateTime = 0.5f;
    
    private void OnEnable()
    {
        Invoke("Inactivate", inactivateTime);
    }

    private void Inactivate() => gameObject.SetActive(false);
}
