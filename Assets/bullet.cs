using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name); // Log collision
        if (collision.gameObject.layer == 7)
        {
            Debug.Log("Collision with layer 7 object: " + collision.gameObject.name);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}

