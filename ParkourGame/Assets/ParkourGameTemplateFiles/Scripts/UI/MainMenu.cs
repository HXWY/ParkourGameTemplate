using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //*************************General*************************\\
    public GameObject AnyButtonText;
    public GameObject ButtonCanvas;

    void Start()
    {
        ButtonCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            AnyButtonText.SetActive(false);
            ButtonCanvas.SetActive(true);
        }
    }
    //*************************Ambience Studios Splash*************************\\
    public void RemoveStartUp()
    {
        SceneManager.LoadScene(1);
    }
    //*************************Press Any Button*************************\\
   
    //*************************Main Menu Functions*************************\\
    //New Game Function
    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }
    //Exit Game Function
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}