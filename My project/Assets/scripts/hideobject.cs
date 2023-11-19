using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideobject : MonoBehaviour
{
    public GameObject BSphere;
    void Start()
    {
        
    }

    public void hide()
    {
        if
            (BSphere.activeInHierarchy)
        {
            BSphere.SetActive(false);
        }
        else
        {
            BSphere.SetActive(true);
        }
    }
}
