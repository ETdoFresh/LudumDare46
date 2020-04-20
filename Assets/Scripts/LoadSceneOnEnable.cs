using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnEnable : MonoBehaviour
{
    public string sceneName;

    private void OnEnable()
    {
        FadeToBlack.LoadScene(sceneName);
    }
}