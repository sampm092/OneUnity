using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonggakScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float tonggakSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * tonggakSpeed * Time.deltaTime;
    }
}
