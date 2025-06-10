using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreText;

[ContextMenu("Increase Score")]
    public void AddScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = score.ToString();
    }
    
}
