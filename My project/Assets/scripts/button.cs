//button
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class button : MonoBehaviour
{
    public GameObject sphere;
    public float xPos;
    public float yPos;
    public float zPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onButtonPress()
    {
        xPos = Random.Range(2.06f, 2.7f);
        yPos = Random.Range(3.07f, 3.71f);
        zPos = Random.Range(10.120f, 10.973f);

        sphere.transform.position = new Vector3(xPos, yPos, zPos);
        sphere.GetComponent<Rigidbody>().Sleep();
    }
}
