using UnityEngine;

public class TriggerTalk : MonoBehaviour
{
    public DialogWindow dialogWindow;
    public bool readyToTalk;

    private void Start()
    {
        dialogWindow = FindObjectOfType<DialogWindow>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!dialogWindow.gameObject.activeSelf)
            {
                dialogWindow.gameObject.SetActive(true);
                dialogWindow.SetText("Hey, you have Corona Virus!");
            }
            else
            {
                dialogWindow.gameObject.SetActive(false);
            }
        }

        if (!readyToTalk)
            dialogWindow.gameObject.SetActive(false);
    }
}