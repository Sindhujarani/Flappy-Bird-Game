using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript1 logic;
    public bool birdIsAlive = true;

    void Start()
    {
       // logic = GameObject.FindGameObjectsWithTag("Logic").GetComponent<LogicScript1>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript1>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true )
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            // myRigidbody.velocity = Vector2.up * 10;
        }

        if (transform.position.y < -6f && birdIsAlive)
        {
            birdIsAlive = false;
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnBird");
    }
}
