using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float tonggakSpeed = 4;
    public float erasePosition = -25;

    public float dashSpeedMultiplier = 1.25f;
    public LogicScript LScript;
    public PlayerScript PScript;

    void Start()
    {
        LScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
         float currentSpeed = tonggakSpeed;
        if (transform.position.x < erasePosition)
        {
            Destroy(gameObject);
        }

        if (LScript.isGameOver == true)
        {
            tonggakSpeed = 0;
        }
        transform.position = transform.position + Vector3.left * currentSpeed * Time.deltaTime;
    }
}
