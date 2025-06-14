using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D MyRigid;
    public float jump;
    public float dash = 1f;
    public float dashTime = 0.2f;
    public float wait = 1;
    public LogicScript Logic;
    public bool isAlive = true;
    public bool isDashing = false;
    private Coroutine DashCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isAlive) //is true
        {
            MyRigid.velocity = Vector2.up * jump;
        }
        if (Input.GetMouseButtonDown(1))
        {
            // MyRigid.velocity = Vector2.right * dash;
            if (DashCoroutine == null)
            {
                DashCoroutine = StartCoroutine(Dash());
            }
            //when click fasten the spawn rate
        }
        if (Input.GetMouseButtonDown(0))
        {
            MyRigid.velocity = Vector2.left * wait;
            //fire bullet to destroy wall
        }
    }
    IEnumerator Dash()
    {
        isDashing = true;
        // float originalGravity = MyRigid.gravityScale;
        MyRigid.velocity = new Vector2(dash, 0); //move horizontally 

        yield return new WaitForSeconds(dashTime);

        isDashing = false;
        DashCoroutine = null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        Logic.GameOver();

    }
}
