using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomStarSpawner : MonoBehaviour
{
    public int numberOfStars = 50;
    public List<Sprite> sprites = new List<Sprite>();
    public Vector2 minPosition;
    public Vector2 maxPosition;
    public float minScale = 0.5f;
    public float maxScale = 2f;

    private void OnEnable()
    {
        for (var i = 0; i < numberOfStars; i++)
        {
            var starGameObject = new GameObject("Star");
            var starSpriteRenderer = starGameObject.AddComponent<SpriteRenderer>();
            starSpriteRenderer.sprite = sprites[Random.Range(0, sprites.Count)];
            starGameObject.transform.SetParent(transform);
            var randomScale = Random.Range(minScale, maxScale);
            var randomPositionX = Random.Range(minPosition.x, maxPosition.x) + transform.position.x;
            var randomPositionY = Random.Range(minPosition.y, maxPosition.y) + transform.position.y;
            var randomRotation = Random.Range(0f, 360f);
            var randomAlpha = Random.Range(0f, 1f);
            starGameObject.transform.localScale = Vector3.one * randomScale;
            starGameObject.transform.position = new Vector3(randomPositionX, randomPositionY, 0);
            starGameObject.transform.eulerAngles = new Vector3(0, 0, randomRotation);
            var color = Color.white;
            color.a = randomAlpha;
            starSpriteRenderer.color = color;
            starSpriteRenderer.sortingOrder = -10000;
        }
    }

    private void OnDisable()
    {
        for(var i = transform.childCount-1; i >= 0; i--)
            Destroy(transform.GetChild(i).gameObject);
    }
}
