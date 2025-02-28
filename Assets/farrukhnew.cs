using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farrukhnew : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript Logic;
    public bool birdIsAlive = true;
    public float topDeadzone = 18;
    public double bottomDeadzone = -17.5;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > topDeadzone || transform.position.y < bottomDeadzone)
        {
            Logic.gameOver();
            birdIsAlive = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Logic.gameOver();
        birdIsAlive = false;
    }
}
