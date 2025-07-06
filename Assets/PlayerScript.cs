using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D MyRigid;
    public GameObject PauseMenu;
    public float jump;
    public float dash = 1f;
    public float dashTime = 0.2f;
    public float wait = 1;
    public LogicScript Logic;
    public bool isAlive = true;
    public bool isDashing = false;
    private Coroutine DashCoroutine;
    public bool isPaused = false;
    private int erasePos = -10;
    public AudioSource AuRetry;
    public AudioClip Flap;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        AuRetry = FindObjectOfType<AudioSource>();
        if (isAlive == false || Logic.isGameOver)
        {
            Destroy(MyRigid);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isAlive) //is true
        {
            MyRigid.velocity = Vector2.up * jump;
            if (Flap != null && AuRetry != null)
            {
                AuRetry.PlayOneShot(Flap);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && isAlive) //is true
        {
            TogglePause();
        }
        if (Input.GetMouseButtonDown(1) && isAlive)
        {
            // MyRigid.velocity = Vector2.right * dash;
            if (DashCoroutine == null)
            {
                DashCoroutine = StartCoroutine(Dash());
            }
            //when click fasten the spawn rate
        }
        if (Input.GetMouseButtonDown(0) && isAlive)
        {
            MyRigid.velocity = Vector2.left * wait;
            //fire bullet to destroy wall
        }

        if (isAlive && MyRigid.transform.position.y < erasePos)
        {
            isAlive = false;
            Logic.GameOver();
        }
        if (Logic.score == 20 && isAlive == true)
        {
            Logic.Finish();
            isAlive = false;
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

    public void TogglePause()
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0 : 1;
        PauseMenu.SetActive(isPaused); // Enable or disable pause menu UI
    }
}
