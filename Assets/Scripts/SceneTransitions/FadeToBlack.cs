using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeToBlack : MonoBehaviour
{
    public static FadeToBlack singleton;

    public bool isFadingOut;
    public bool isFadingIn;
    public Image image;
    public Color color;
    public float duration = 0.5f;
    public string sceneName;
    
    private float startTime;
    private float endTime;

    private void OnValidate()
    {
        if (!image) image = GetComponentInChildren<Image>();
    }

    private void Start()
    {
        singleton = this;
        image.enabled = false;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += HideFade;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= HideFade;
    }

    private void Update()
    {
        if (isFadingOut)
        if (Time.time < endTime)
        {
            color.a = (Time.time - startTime) / duration;
            image.color = color;
        }
        else
        {
            color.a = 1;
            image.color = color;
            SceneManager.LoadScene(sceneName);
            startTime = endTime = 0;
        }
        
        if (isFadingIn)
            if (Time.time < endTime)
            {
                color.a = 1 - (Time.time - startTime) / duration;
                image.color = color;
            }
            else
            {
                isFadingIn = false;
                image.raycastTarget = true;
                image.enabled = false;
                startTime = endTime = 0;
            }
    }

    public void HideFade(Scene arg0, LoadSceneMode loadSceneMode)
    {
        isFadingOut = false;
        isFadingIn = true;
        color = Color.black;
        image.color = color;
        image.raycastTarget = false;
        startTime = Time.time;
        endTime = startTime + duration;
    }

    public static void LoadScene(string sceneName)
    {
        if (!singleton.isFadingOut)
        {
            singleton.image.enabled = true;
            singleton.startTime = Time.time;
            singleton.color = Color.clear;
            singleton.image.color = singleton.color;
            singleton.endTime = Time.time + singleton.duration;
            singleton.sceneName = sceneName;
            singleton.isFadingIn = false;
            singleton.isFadingOut = true;
        }
    }
}
