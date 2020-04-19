using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.SceneManagement;

public class SpaceExplosionSceneScript : MonoBehaviour
{
    public float flyThroughSpaceDelay = 1;
    public float cameraShakeDuration = 1;
    public float recoveryDelay = 1;
    public bool hasReadDialog;

    public GameObject explosionPrefab;
    public CameraShake cameraShake;
    public string sceneName;
    
    public Coroutine currentCoroutine;

    private void OnEnable()
    {
        if (currentCoroutine != null)
            StopCoroutine(currentCoroutine);

        currentCoroutine = StartCoroutine(FlyThroughSpace());
    }

    private IEnumerator FlyThroughSpace()
    {
        yield return new WaitForSeconds(flyThroughSpaceDelay);
        currentCoroutine = StartCoroutine(ExplodeAndCameraShake());
    }

    private IEnumerator ExplodeAndCameraShake()
    {
        var explosion = Instantiate(explosionPrefab);
        cameraShake.enabled = true;
        yield return new WaitForSeconds(cameraShakeDuration);
        cameraShake.enabled = false;
        currentCoroutine = StartCoroutine(Recover());
    }

    private IEnumerator Recover()
    {
        yield return new WaitForSeconds(recoveryDelay);
        currentCoroutine = StartCoroutine(ReadDialog());
    }

    private IEnumerator ReadDialog()
    {
        yield return null;
        SceneManager.LoadScene(sceneName);
    }
}