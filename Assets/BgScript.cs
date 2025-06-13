using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScript : MonoBehaviour
{
    public SpriteRenderer Background;
    public float scrollSpeed = 0.5f; // fot background speed
    public float resetPositionX = -8; // Where to reset the tile
    public float startPositionX = 5; // Where to move it back to
    private float BgWidth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        Background.transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        if (Background.transform.position.x <= resetPositionX)
        {
            Background.transform.position = new Vector3(startPositionX, Background.transform.position.y, Background.transform.position.z); // resetting background t
        }
    }
}
