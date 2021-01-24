using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
		
        private void OnTriggerEnter2D(Collider2D other)
        {
            //restart the scene if triggered by the player
			if (other.tag == "Player") {
				SceneManager.LoadScene (SceneManager.GetSceneAt (0).name);
			} 
        }
    }
}
