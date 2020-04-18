using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleDialogTalker : MonoBehaviour
{
    public string sceneName = "";
    public List<string> text = new List<string>
    {
        "Hey there!",
        "What's going on?",
        "Are you sure you talking to me?",
        "Hey, I'm walking here!",
        "Later"
    };

    public int index;

    private void OnEnable()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    public void ShowDialog()
    {
        Main.singleton.dialogWindow.ShowText(name, text[index]);
        index = (index + 1) % text.Count;
    }
}
