using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public GameObject StartMenu;
    public GameObject ExitMenu;
    // Start is called before the first frame update
    void Start()
    {
        // Replace with your actual scene name
    }

    public void StartScene()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // Only shows in editor
    }
}
