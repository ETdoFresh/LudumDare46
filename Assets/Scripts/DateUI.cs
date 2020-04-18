using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DateUI : MonoBehaviour
{
    public static DateUI singleton;
    public TextMeshProUGUI textMesh;

    private void OnValidate()
    {
        if (!textMesh) textMesh = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Start()
    {
        singleton = this;
        DontDestroyOnLoad(gameObject);        
    }

    public static void SetDate(string text)
    {
        if (singleton && singleton.textMesh)
            singleton.textMesh.text = text;
    }

    public static void Destroy()
    {
        if (!singleton) return;
        
        Destroy(singleton.gameObject);
        singleton = null;
    }
}
