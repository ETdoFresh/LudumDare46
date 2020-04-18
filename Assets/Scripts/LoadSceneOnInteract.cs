using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Interaction))]
public class LoadSceneOnInteract : MonoBehaviour
{
    public string sceneName;
    public Interaction interaction;

    private void OnValidate()
    {
        if (!interaction) interaction = GetComponent<Interaction>();
    }

    private void OnEnable()
    {
        AddCallback(interaction.onInteract, LoadScene);
    }

    private void OnDisable()
    {
        RemoveCallback(interaction.onInteract, LoadScene);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
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