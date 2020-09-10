using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    public GameObject PauseMenuCanvas;
    public static bool GameIsPaused = false;

    // Update is called once per frame
    void Start()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
    //**********************Pause Menu**********************//
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            } 
        } 
    }
    public void Resume()
    {
        Cursor.visible = false;
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Pause()
    {
        Cursor.visible = true;
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void Options()
    {

    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Clicked");
    }
    public void ExitToDesktop()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
