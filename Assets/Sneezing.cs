using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sneezing : MonoBehaviour
{
    public bool sneezed = false;
    public Animator anim;
    public GameObject coronaSneeze;
    public GameObject player;
    public bool right = true;
    public float distance = 5.0f;
    public bool changedColor = false;
    public Color origColor;
    public Color closeColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        if(!anim)
        {
            anim = this.GetComponent<Animator>();
        }

        if(!player)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            origColor = player.GetComponent<SpriteRenderer>().color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!sneezed)
        {
            sneezed = true;
            StartCoroutine(Sneez());
        }

        if(player)
        {
            if(Mathf.Abs(player.transform.position.x - this.transform.position.x) <= distance && Mathf.Abs(player.transform.position.y - this.transform.position.y) < 1.0f)
            {
                player.GetComponent<SpriteRenderer>().color = closeColor;                
            }
            

            if (player.transform.position.x - this.transform.position.x > 0)
            {
                if (!right)
                {
                    transform.localRotation = Quaternion.Euler(0, 180, 0);
                }
                right = true;

            }
            else
            {
                if (right)
                {
                    transform.localRotation = Quaternion.Euler(0, 0, 0);
                }
                right = false;
            }
        }
        
        
    }
    IEnumerator Sneez()
    {
        if(anim)
        {
            anim.SetBool("Sneezing", true); 
            while(anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                yield return null;
            }
            anim.SetBool("Sneezing", false);
            GameObject corona = Instantiate<GameObject>(coronaSneeze, new Vector3(transform.position.x, transform.position.y +(float)0.3, transform.position.z), Quaternion.identity);

            corona.GetComponent<CoronaSneeze>().right = right;
        }
        yield return new WaitForSeconds(5);
        sneezed = false;
    }
}
