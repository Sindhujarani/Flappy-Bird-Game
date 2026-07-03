using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float maxLifetime = 10f;

    void Start()
    {
        // Destroy bullet after 'lifetime' seconds
        Destroy(gameObject, maxLifetime);
    }

    void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void DestroyMe()
    {
        Destroy(gameObject);
    }
}
