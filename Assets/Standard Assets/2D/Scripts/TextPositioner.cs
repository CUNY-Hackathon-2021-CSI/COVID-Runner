using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPositioner : MonoBehaviour
{       
    Vector3 threshold;

    //public text
    public GameObject textScore;
    


    // Start is called before the first frame update
    void Start()
    {
        //text threshold 
        threshold = textScore.transform.position - this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //text holder
        Vector3 namePOS = this.transform.position + threshold;
        textScore.transform.position = namePOS;
    }

   

}
