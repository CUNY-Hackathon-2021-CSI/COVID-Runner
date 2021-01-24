using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaSneeze : MonoBehaviour
{
    public bool startFlying = false;
    public float speed = (float)1.0;
    public float origX;
    public bool right = true;
    public float distance = (float) 3.0;
    // Start is called before the first frame update
    void Start()
    {
        origX = transform.position.x;
    }

    private void FixedUpdate()
    {
        if(!startFlying)
        {
            StartCoroutine(Fly());
            startFlying = true;
        }

        if(right)
        {
            transform.position = new Vector3(transform.position.x + speed * (float)0.01, transform.position.y, transform.position.z);
            if(transform.position.x - origX > distance)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed * (float)0.01, transform.position.y, transform.position.z);
            if (origX - transform.position.x > distance)
            {
                Destroy(this.gameObject);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.gm.Damage();
            Destroy(this.gameObject);
        }
    }

    IEnumerator Fly()
    {
        yield return new WaitForSeconds(1);        
    }
}
