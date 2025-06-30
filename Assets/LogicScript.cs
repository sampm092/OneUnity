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
    public UFOscript UScript;
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

    public void Exit1()
    {
        PScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        PScript.TogglePause();
        SceneManager.LoadScene("StartScene");
    }

    public void Resume1()
    {
        PScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        PScript.TogglePause();
    }

    public void Exit2()
    {
        UScript = GameObject.FindGameObjectWithTag("Player").GetComponent<UFOscript>();
        UScript.TogglePause();
        SceneManager.LoadScene("StartScene");
    }

    public void Resume2()
    {
        UScript = GameObject.FindGameObjectWithTag("Player").GetComponent<UFOscript>();
        UScript.TogglePause();
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
