using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

   
    public float moveSpeed = 5;
    public float deadZone = -30;
    public bool isBlocked = false;
    // Start is called before the first frame update
    public GameObject topPip;
    public GameObject bottomPip;
    public GameObject button;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

         if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }

    
    public void SetUpPipes(bool block)
    {
        isBlocked = block;
        if (isBlocked)
        {
            //initialized closec path
            bottomPip.transform.localPosition = new Vector3(bottomPip.transform.localPosition.x, -2.68f, bottomPip.transform.localPosition.z);
            button.SetActive(true);
        }
        else {
            //initialized openpath.
            bottomPip.transform.localPosition = new Vector3(bottomPip.transform.localPosition.x, -5.37f, bottomPip.transform.localPosition.z);
            button.SetActive(false);
        }
    }

   
}
