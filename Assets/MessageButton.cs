using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageButton: MonoBehaviour
{
    public GameObject messageButton;
    public TextMeshPro messageToShow;
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
}
