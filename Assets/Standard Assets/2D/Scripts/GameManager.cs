using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

public class GameManager : MonoBehaviour
{
    //public valiables
    public static GameManager gm = null;
    public int health = 2;
    public int maskHealth = 4;
    public bool maskOn = false;
    public Text hintText;
    public Text gameOverText;
    public GameObject wonText;
    public Image healthImage;
    public Image gameOverCover;
    public Image maskUiImage;
    public GameObject barUI;
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
    public GameObject player;
    public Slider slider;
    public bool coronaTriggerEnter = false;
    public bool maskTriggerEnter = false;
    public bool distanceTriggerEnter = false;
    public Image hintPanel;


    // Start is called before the first frame update
    void Start()
    {
        if(gm == null)
        {
            gm = this;
            hintText.gameObject.SetActive(false);
            wonText.gameObject.SetActive(false);
            gameOverCover.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(false);
            maskUiImage.gameObject.SetActive(false);
            barUI.gameObject.SetActive(false);
            hintPanel.gameObject.SetActive(false);
            healthImage.sprite = fullHeart;
        }
        else
        {
            Destroy(gm);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        if(!maskOn)
        {
            health--;

            if (health == 1)
            {
                healthImage.sprite = halfHeart;

            }
            else if (health == 0)
            {
                healthImage.sprite = emptyHeart;
                Destroy(player.gameObject);
                gameOverCover.gameObject.SetActive(true);
                gameOverText.gameObject.SetActive(true);
                StartCoroutine(RestartGame());
            }
        }
        else
        {
            maskHealth--;
            slider.value = maskHealth;

            if(maskHealth <= 0)
            {
                maskOn = false;                
            }

        }
        
        
    }

    public void TriggerMessage()
    {
        StartCoroutine(WaitMessage());
    }

    IEnumerator WaitMessage()
    {
        yield return new WaitForSeconds(10);
        hintText.gameObject.SetActive(false);
    }

    public void EndGame()
    {
        wonText.gameObject.SetActive(true);
        gameOverCover.gameObject.SetActive(true);
        Destroy(player.gameObject);        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }
   

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }
}
