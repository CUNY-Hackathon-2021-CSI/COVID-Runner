using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageButton: MonoBehaviour
{
    public GameObject messageButton;
    //public GameObject messageToShow;
    public static string [] messages = {
                                    "Welcome to COVID-Runner!",
                                    "Covid is lurking (in broad daylight)",
                                    "The objective of the game is to get all the pieces together and complete the vaccine, without getting too sick along the way.",
                                };
    public static int messageIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
       // messageButton = new Button()
        // messageButton.transform.width = messageToShow.transform.width;
        // messageButton.transform.height = messageToShow.transform.height;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("space")) 
        {
            messageButton.SetActive(false);
        }
    }

    public void DisappearButton()
    {
        messageButton.SetActive(false);
    }

    public void SetMessage(string message)
    {
        //messageToShow.text = message;
    }

    public void ShowNextMessage() 
    {
        if (messageIndex < messages.Length)
            messageButton.GetComponentInChildren<TMP_Text>().text = messages[messageIndex++];
        else
            messageButton.SetActive(false);
    }
}
