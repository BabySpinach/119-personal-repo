using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ButtonPressFunctions : MonoBehaviour
{
    public GameObject controlsMenu;
    public GameObject canvas;
    public GameObject video;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && controlsMenu.activeInHierarchy)
            controlsMenu.SetActive(false);
        
        VideoPlayer player = video.GetComponent<VideoPlayer>();
        if (video.activeInHierarchy && (long)player.frameCount == player.frame + 1)
            SceneManager.LoadScene("Game");
    }
    public void OnStartButtonPressed()
    {
        //video.GetComponent<VideoPlayer>().frame = 0;
        canvas.SetActive(false);
        video.SetActive(true);
        
    }

    public void OnOptionsButtonPressed()
    {
        controlsMenu.SetActive(true);
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

    public void OnGameMainButtonPressed()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
