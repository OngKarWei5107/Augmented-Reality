using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameController : MonoBehaviour
{
    public Text textDisplay;
    public AudioClip[] aClips;

    public AudioSource audioClip1;
    string objName;

    private void Start()
    {
        audioClip1 = GetComponent<AudioSource>();
    }

    void Update () {
      if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit))
                {
                    objName = Hit.transform.name;
                    switch (objName)
                    {
                        case "object1":

                            textDisplay.text = "Try it again?";
                            audioClip1.clip = aClips[0];
                            audioClip1.Play();
                            break;
                        case "object2":
                            textDisplay.gameObject.SetActive(false);
                            textDisplay.text = "Try it again?";
                            audioClip1.clip = aClips[1];
                            audioClip1.Play();
                            break;
                        case "object3":
                            textDisplay.gameObject.SetActive(false);
                            textDisplay.text = "Congratulations!!!";
                            audioClip1.clip = aClips[2];
                            audioClip1.Play();
                            break;
                        case "object4":
                            textDisplay.gameObject.SetActive(false);
                            textDisplay.text = "Try it again?";
                            audioClip1.clip = aClips[3];
                            audioClip1.Play();
                            break;
                        default:
                            break;

                    }
                }
            }
            
     }

}
