using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControls : MonoBehaviour
{
    public GameObject attack;
    
    private void Update()
    {
        attack.SetActive(Input.GetButton("Fire1"));
    }
}
