using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuyMessage : MonoBehaviour
{
    //public text
    public Text message;

    private void OnCollisionEnter2D(Collision2D other)
    {
        //display text on collision
        if(other.gameObject.tag == "Player")
        {
            if(message)
            {
                message.gameObject.SetActive(true);
            }
            
        }
        
    }

    private void OnDestroy()
    {
        if(message)
        {
            //destroy message
            Destroy(message.gameObject);
        }
        
    }
}
