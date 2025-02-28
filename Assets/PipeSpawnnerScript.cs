using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnnerScript : MonoBehaviour
{
    public GameObject pipe;
    public GameObject closedPipe;
    private float timer = 0;
    public float spawnrate = 2;
    public float heightofSet = 10;
    public ParticleSystem particle;
    private LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
        particle.Play();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (logic.playerscore < 3)
            {
                Spawnpipe();
                timer = 0;
            }
            else
            {
                SpawnClosedpipe();
                timer = 0;
            }
        }
    }

    void Spawnpipe()
    {
        float lowestpoint = transform.position.y - heightofSet;
        float highestpoint = transform.position.y + heightofSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }

    void SpawnClosedpipe()
    {
        float lowestpoint = transform.position.y - heightofSet;
        float highestpoint = transform.position.y + heightofSet;
        GameObject newClosedPipe = Instantiate(closedPipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);

        // Ensure the ClosedPipeScript is attached
        if (newClosedPipe.GetComponent<ClosedPipeScript>() == null)
        {
            newClosedPipe.AddComponent<ClosedPipeScript>();
        }

        Debug.Log("Spawned closed pipe at position: " + newClosedPipe.transform.position);
    }
}
