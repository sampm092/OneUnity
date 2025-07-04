using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redwall : MonoBehaviour
{
    public AudioSource AuRetry;
    public AudioClip nodestroy;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        AuRetry = FindObjectOfType<AudioSource>();
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (nodestroy != null && AuRetry != null)
            {
                AuRetry.PlayOneShot(nodestroy);
            }
        }
    }
}
