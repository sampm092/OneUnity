using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpwncript : MonoBehaviour
{
    public GameObject wall;
    public float spawnRate = 4;
    public float heightOffset = 10;
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
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float RotatePoint = Random.Range(-30, 30);
        Instantiate(wall, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0),  Quaternion.Euler(0, 0, RotatePoint));
    }
}
