using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunLogic : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 15f;

    private LogicScript logic;

    void Start()
    {
        gameObject.SetActive(false);
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void Update()
    {
        if (logic.playerscore >= 3)
        {
            gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Enter key pressed");
                FireBullet();
                
            }
        }
    }

    private void FireBullet()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = bulletSpawnPoint.right * bulletSpeed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component missing on bulletPrefab.");
        }
    }
}

