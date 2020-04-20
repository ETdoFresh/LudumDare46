using UnityEngine;
using UnityEngine.EventSystems;

public class LaunchTowardsMoon : MonoBehaviour, IPointerDownHandler
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
    public void OnPointerDown(PointerEventData eventData)
    {
        if (canLaunchShip)
            FadeToBlack.LoadScene(sceneName);
    }
}
