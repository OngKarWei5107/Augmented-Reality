using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class VButtonManager : MonoBehaviour, IVirtualButtonEventHandler
{

    public VideoPlayer videoPlayer;
    public GameObject playButton;
    private int x = 0;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        x++;
        if (x%2 != 0)
        {
            videoPlayer.Play();
            playButton.GetComponent<Renderer>().enabled = false;
            audioSource.Pause();
        }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (x % 2 == 0)
        {
            videoPlayer.Pause();
            playButton.GetComponent<Renderer>().enabled = true;
            audioSource.Play();
        }
        
    }
}
