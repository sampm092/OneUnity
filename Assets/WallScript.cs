using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float tonggakSpeed = 4;
    public float erasePosition = -25;

    public float dashSpeedMultiplier = 1.25f;
    // public LogicScript LogicS;
    public PlayerScript PScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float currentSpeed = tonggakSpeed;
        if (transform.position.x < erasePosition)
        {
            Destroy(gameObject);
        }

        // if (LogicS.isGameOver == true)
        // {
        //     tonggakSpeed = 0;
        // }

        // if (PScript.isDashing) // reference to your player script
        // {
        //     currentSpeed *= dashSpeedMultiplier;
        // }

        transform.position = transform.position + Vector3.left * currentSpeed * Time.deltaTime;
    }
}
