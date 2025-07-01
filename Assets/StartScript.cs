using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public GameObject StartMenuV1;
    public GameObject StartMenuV2;
    public GameObject ExitMenu;
    // Start is called before the first frame update
    void Start()
    {
        // Replace with your actual scene name
    }

    public void StartSceneV1()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    
    public void StartSceneV2()
    {
        SceneManager.LoadScene("Try"); 
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // Only shows in editor
    }
}
