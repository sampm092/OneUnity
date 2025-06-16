using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool isGameOver = false;
    public AudioClip Sfx;
    private AudioSource AudioSource; //

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = score.ToString();
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        AudioSource = FindObjectOfType<AudioSource>();
        gameOverScreen.SetActive(true);
        if (Sfx != null && AudioSource != null)
        {
            AudioSource.PlayOneShot(Sfx);
        }
        isGameOver = true;
    }



}
