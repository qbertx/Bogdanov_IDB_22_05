using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colls : MonoBehaviour
{
    public TMPro.TextMeshProUGUI lbl;
    void Start()
    {
        
    }
    public int i = 0;
    void OnCollisionEnter(Collision collision)
    {
        i++;
        lbl.text = "Collisions : " + i;
    }
}
