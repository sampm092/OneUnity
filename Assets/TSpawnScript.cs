using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnTonggak();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnTonggak();
            timer = 0;

        }
    }

    void spawnTonggak()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
