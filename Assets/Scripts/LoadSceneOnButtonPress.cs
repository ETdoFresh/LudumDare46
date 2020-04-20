using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LoadSceneOnButtonPress : MonoBehaviour
{
    public Button button;
    public string sceneName;

    private void OnValidate()
    {
        if (!button) button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        AddCallback(button.onClick, LoadScene);
    }

    private void OnDisable()
    {
        RemoveCallback(button.onClick, LoadScene);
    }

    public void LoadScene()
    {
        FadeToBlack.LoadScene(sceneName);
    }

    public void AddCallback(UnityEvent unityEvent, UnityAction action)
    {
#if UNITY_EDITOR
        UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent, action);
#else
        unityEvent.AddListener(action);
#endif
    }

    public void RemoveCallback(UnityEvent unityEvent, UnityAction action)
    {
#if UNITY_EDITOR
        UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, action);
#else
        unityEvent.RemoveListener(action);
#endif
    }
}