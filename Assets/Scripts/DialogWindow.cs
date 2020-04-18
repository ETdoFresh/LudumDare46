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

    public void ShowText(string text)
    {
        gameObject.SetActive(true);
        this.text.text = text;
    }

    public void HideText()
    {
        gameObject.SetActive(false);
    }
}