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
    public AudioClip Over;
    public PlayerScript PScript;
    public AudioClip Retry;
    // private AudioSource AudioSource; 
    private AudioSource AuRetry;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = score.ToString();
    }

    public void RetryGame()
    {
        StartCoroutine(ReloadSceneWithSound());
    }

    public void GameOver()
    {
        AuRetry = FindObjectOfType<AudioSource>();
        gameOverScreen.SetActive(true);
        if (Over != null && AuRetry != null)
        {
            AuRetry.PlayOneShot(Over);
        }
        isGameOver = true;
    }

    public void Exit()
    {
        PScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        PScript.TogglePause();
        SceneManager.LoadScene("StartScene");
    }

    public void Resume()
    {
        PScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        PScript.TogglePause();
    }

    IEnumerator ReloadSceneWithSound()
    {
        if (Retry != null && AuRetry != null)
        {
            AuRetry.PlayOneShot(Retry);
            yield return new WaitForSeconds(0.2f); // Wait for sound to finish
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
