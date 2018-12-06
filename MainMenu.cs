using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
   
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void TakePhoto()
    {
        SceneManager.LoadScene("Camera");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ViewCapturedPhoto()
    {
        SceneManager.LoadScene("ImageViewer");
    }

    public void ExitApp()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
