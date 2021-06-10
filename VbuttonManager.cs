using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class VbuttonManager : MonoBehaviour, IVirtualButtonEventHandler
{
    public VideoPlayer player;
    public GameObject playButton;
    private int x = 0;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        x++;
        if (x%2 !=0)
        {
            player.Play();
            playButton.GetComponent<Renderer>().enabled = false;
            audioSource.Pause();
        }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        x++;
        if (x % 2 == 0)
        {
            player.Play();
            playButton.GetComponent<Renderer>().enabled = true;
            audioSource.Play();
        }
    }
}
