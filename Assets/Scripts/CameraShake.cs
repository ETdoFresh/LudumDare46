using System;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public new Camera camera;
    public Vector3 cameraStartingPosition;

    private void OnValidate()
    {
        if (!camera) camera = GetComponent<Camera>();
    }

    private void OnEnable()
    {
        cameraStartingPosition = camera.transform.position;
    }

    private void OnDisable()
    {
        camera.transform.position = cameraStartingPosition;
    }
}