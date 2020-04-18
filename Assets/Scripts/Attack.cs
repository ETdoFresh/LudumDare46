using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"{name} -> {other.name}");
        if (other.GetComponent<Enemy>())
            Destroy(other.gameObject);
        
    }
}