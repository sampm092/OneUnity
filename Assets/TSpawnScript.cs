using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 0;
    public bool stop = true;
    public PlayerScript PScript;



    // Start is called before the first frame update
    void Start()
    {
        SpawnTonggak();

        PScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float dashSpeedMultiplier = 1.25f;
        float interval = PScript.isDashing ? spawnRate / dashSpeedMultiplier : spawnRate;
        timer += Time.deltaTime;
        if (PScript.isAlive == false) //Prevent spawning tonggak after game over
        {

        }
        else
        {
            if (timer > interval)
            {
                SpawnTonggak();
                timer = 0;

            }
        }
    }

    void SpawnTonggak()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

}
