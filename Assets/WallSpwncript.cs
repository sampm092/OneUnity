using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpwncript : MonoBehaviour
{
    public GameObject wall;
    public float spawnRate = 2;
    // public float heightOffset = 10;
    private float timer = 0;
    public bool stop = true;
    // public PlayerScript PScript;
    // Start is called before the first frame update
    void Start()
    {
        SpawnWall();
        
        // PScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // float dashSpeedMultiplier = 1.25f;
        float interval = spawnRate ;
        timer += Time.deltaTime;
        // if (PScript.isAlive == false) //Prevent spawning tonggak after game over
        // {

        // }
        // else
        // {
            if (timer > interval)
            {
                SpawnWall();
                timer = 0;

            }
        // }
    }

    void SpawnWall()
    {
        Instantiate(wall, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
