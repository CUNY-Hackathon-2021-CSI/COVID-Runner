using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaTravel : MonoBehaviour
{
    public float startPos;
    public float startPosY;
    public float offSet = 5.0f;
    public float speed = 5.0f;
    public bool vertical = false;
    public bool right = true;
    public bool down = false;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        startPosY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!vertical)
        {
            if (right)
            {
                if (transform.position.x > startPos + offSet)
                {
                    right = false;
                }
                else
                {
                    transform.position = new Vector3(transform.position.x + speed * (float)0.01, transform.position.y, transform.position.z);
                }
            }
            else
            {                

                if (transform.position.x <= startPos)
                {
                    right = true;
                }
                else
                {
                    transform.position = new Vector3(transform.position.x - speed * (float)0.01, transform.position.y, transform.position.z);
                }
            }
        }
        else
        {
            if (down)
            {
                if (transform.position.y < startPosY - offSet)
                {
                    down = false;
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speed * (float)0.01, transform.position.z);
                }
            }
            else
            {

                if (transform.position.y >= startPosY)
                {
                    down = true;
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + speed * (float)0.01, transform.position.z);
                }
            }
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.gm.Damage();
            Destroy(this.gameObject);
        }
    }
}
