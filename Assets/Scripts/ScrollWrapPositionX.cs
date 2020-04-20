using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollWrapPositionX : MonoBehaviour
{
    public Transform repeat;
    public float speed = 1;
    public float maxX = 10;
    public float minX = 0;

    private void Update()
    {
        var position = repeat.transform.localPosition;
        position.x -= speed * Time.deltaTime;
        if (position.x < minX) position.x = maxX;
        repeat.transform.localPosition = position;
    }
}