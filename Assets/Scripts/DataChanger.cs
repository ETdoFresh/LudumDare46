using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataChanger : MonoBehaviour
{
    public string date;

    private void OnEnable()
    {
        DateUI.SetDate(date);
    }
}
