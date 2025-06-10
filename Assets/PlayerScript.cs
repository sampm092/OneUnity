using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D MyRigid;
    public float jump;
    public float dash = 3;
    public float wait = 1;
    // public TonggakScript TonggakS;
    // Start is called before the first frame update
    void Start()
    {
        // TonggakS = GameObject.FindGameObjectWithTag("Tonggak").GetComponent<TonggakScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            MyRigid.velocity = Vector2.up * jump;
        }
        if (Input.GetMouseButtonDown(1))
        {
            MyRigid.velocity = Vector2.right * dash;
            //when click fasten the spawn rate
        }
        if (Input.GetMouseButtonDown(0))
        {
            MyRigid.velocity = Vector2.left * wait;
            //fire bullet to destroy wall
        }
    }
}
