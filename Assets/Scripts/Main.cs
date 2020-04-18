using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public static Main singleton;
    public DialogWindow dialogWindow;

    [RuntimeInitializeOnLoadMethod]
    public static void CreateMainIfNotExists()
    {
        if (singleton) return;

        var mainPrefab = Resources.Load<GameObject>("Main");
        singleton = Instantiate(mainPrefab).GetComponent<Main>();
        singleton.name = "Main";
        DontDestroyOnLoad(singleton.gameObject);
    }

    public static DialogWindow GetDialogWindow()
    {
        if (!singleton) return null;
        return singleton.dialogWindow;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            DateUI.Destroy();
        }
    }
}