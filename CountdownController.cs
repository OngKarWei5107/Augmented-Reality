using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    AudioSource audioClip1;
    private void Start()
    {
        StartCoroutine(CountdownToStart());
        audioClip1 = GetComponent<AudioSource>();
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "END!";
        audioClip1.Play(0);
		
		/* Call the code to "begin" your game here.
		 * For example, mine allows the player to start
		 * moving and starts the in game timer.
         */
		// GameController.instance.BeginGame();

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
    }
}
