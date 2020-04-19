using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LaunchTowardsMoon : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    public string sceneName;
    public bool canLaunchShip;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<SpaceShip>())
            canLaunchShip = true;
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<SpaceShip>())
            canLaunchShip = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (canLaunchShip)
            SceneManager.LoadScene(sceneName);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (canLaunchShip)
            SceneManager.LoadScene(sceneName);
    }
}
