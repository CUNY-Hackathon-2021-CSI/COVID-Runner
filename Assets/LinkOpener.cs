using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LinkOpener : MonoBehaviour
{
    public void OnPointerClick()
    {
        Application.OpenURL("https://www.cdc.gov/coronavirus/2019-ncov/prevent-getting-sick/prevention.html");
    }
}
