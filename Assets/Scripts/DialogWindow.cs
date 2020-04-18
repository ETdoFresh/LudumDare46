using System;
using UnityEngine;
using UnityEngine.UI;

public class DialogWindow : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    public void SetText(string text)
    {
        this.text.text = text;
    }
}