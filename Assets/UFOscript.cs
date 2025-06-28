using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D MyRigid;
    public float jump = 10;
    public BulletScript bullet;
    public Transform LaunchOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) //is true
        {
            MyRigid.velocity = Vector2.up * jump;
        }
        if (Input.GetMouseButtonDown(1)) //is true
        {
            Instantiate(bullet, LaunchOffset.position, transform.rotation);
        }

    }
}
