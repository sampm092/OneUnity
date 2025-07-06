using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Walltype
{
    destroyable,
    undestroyable,
};

public class EachWallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip destroyableSound;
    public AudioClip undestroyableSound;
    private AudioSource audioSource;
    public Walltype walltype;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Bullet"))
            return;

        AudioClip clipToPlay = null;

        switch (walltype)
        {
            case Walltype.destroyable:
                clipToPlay = destroyableSound;
                break;
            case Walltype.undestroyable:
                clipToPlay = undestroyableSound;
                break;
        }

        if (clipToPlay != null)
        {
            AudioSource.PlayClipAtPoint(clipToPlay, transform.position);
        }

        if (walltype == Walltype.destroyable)
        {
            Destroy(gameObject);
        }
    }
}
