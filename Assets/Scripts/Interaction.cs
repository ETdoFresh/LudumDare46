﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    public UnityEvent onInteract;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Interactor>())
            onInteract.Invoke();
    }
}
