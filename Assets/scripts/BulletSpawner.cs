using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
   // Drag your bullet prefab here in the Inspector
    public GameObject bulletPrefab;
    
    // Drag an empty GameObject positioned at the gun barrel here
    public Transform spawnPoint;

    void Update()
    {
        // Check for the mouse key press
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        // Creates the bullet at the spawnPoint's position and rotation
        Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
