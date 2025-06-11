using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonggakScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float tonggakSpeed = 4;
    public float erasePosition = -25;

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * tonggakSpeed * Time.deltaTime;

        if (transform.position.x < erasePosition)
        {
            Destroy(gameObject);
        }
    }

    
}
