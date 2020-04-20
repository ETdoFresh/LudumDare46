using System;
using UnityEngine;
using UnityEngine.UI;

public class DialogWindow : MonoBehaviour
{
    public Text speaker;
    public Text dialog;

    private void OnValidate()
    {
        if (!speaker) speaker = GetComponentInChildren<Text>();
        if (!dialog) dialog = GetComponentInChildren<Text>();
    }

    public void ShowText(string name, string text)
    {
        gameObject.SetActive(true);
        speaker.text = name;
        dialog.text = text;
    }

    public void HideText()
    {
        gameObject.SetActive(false);
    }
}