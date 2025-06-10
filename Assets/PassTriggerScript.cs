using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTriggerScript : MonoBehaviour
{
    public LogicScript Logic;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Theres also ontrigger exit and on trigger stay
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Logic.AddScore(1);
        }
    }


}
