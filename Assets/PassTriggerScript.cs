using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTriggerScript : MonoBehaviour
{
    public LogicScript Logic;
    public AudioClip Sfx;
    private AudioSource AudioSource; //
    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = FindObjectOfType<AudioSource>();
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
        void Update()
    {

    }

    //Theres also ontrigger exit and on trigger stay
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered && collision.CompareTag("Player")) //mengambil tag player
        {
            if (Sfx != null && AudioSource != null)
            {
                AudioSource.PlayOneShot(Sfx);
            }
            
            Logic.AddScore(1);
            triggered = true;
        }
    }

}
