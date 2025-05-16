using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPlayerAction : MonoBehaviour
{
    public GameObject canvas;

    private VideoPlayer player;


    // Update is called once per frame
    void Update()
    {
        if ((long)player.frameCount == player.frame + 1)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
