using UnityEngine;

public class LoadSceneOnTimer : MonoBehaviour
{
    public float duration = 1;
    public string sceneName;

    private void Start()
    {
        Invoke("LoadScene", duration);
    }

    private void LoadScene()
    {
        FadeToBlack.LoadScene(sceneName);
    }
}