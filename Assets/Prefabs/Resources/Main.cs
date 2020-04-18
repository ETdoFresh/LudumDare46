using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
