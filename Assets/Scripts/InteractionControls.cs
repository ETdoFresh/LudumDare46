using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionControls : MonoBehaviour
{
    public Interactor interactor;

    private void OnValidate()
    {
        if (!interactor) GetComponentInChildren<Interactor>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (interactor.isInteracting)
            {
                Main.singleton.dialogWindow.HideText();
                interactor.isInteracting = false;
            }
            else if (!interactor.gameObject.activeSelf)
                interactor.gameObject.SetActive(true);
        }
    }
}
