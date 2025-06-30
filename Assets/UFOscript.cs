using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D MyRigid;
    public GameObject PauseMenu;
    public float jump = 10;
    public BulletScript bullet;
    public Transform LaunchOffset;
    public bool isAlive = true;
    public LogicScript Logic;
    private int erasePos = -10;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == false)
        {
            Destroy(MyRigid);
        }

        if (Input.GetKeyDown(KeyCode.Space)) //is true
        {
            MyRigid.velocity = Vector2.up * jump;
        }
        if (Input.GetMouseButtonDown(1)) //is true
        {
            Instantiate(bullet, LaunchOffset.position, transform.rotation);
        }
        if (isAlive && MyRigid.transform.position.y < erasePos)
        {
            isAlive = false;
            Logic.GameOver();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && isAlive) //is true
        {
            TogglePause();
        }
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
